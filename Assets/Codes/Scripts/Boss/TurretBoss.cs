using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBoss : MonoBehaviour
{
    public float speed = 2;
    public float UpAndDownEdge;
    public HealthSystem healthSystem;
    public int damage = 4;
    public GameObject bullet;
    public float cooldownTime = 1.5f;
    public Transform shootingPoint;
    public int turretHP = 5;
    public Shooting shooting;
    public bool canMove;
    public bool shootingTrigger;
    public Boss boss;
    Animator _AnimTurret;
    public EventPhases _EventPhases;
    private void Update()
    {
        if (canMove)
        {
            TurretMove();
        }
        if(cooldownTime<= 0)
        {
            SpawnBullet();
            cooldownTime = 1.5f;
        }
        
        cooldownTime -= Time.deltaTime;
    }

    private void Start()
    {
        _AnimTurret = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            turretHP -= shooting.damage;
            if (turretHP <= 0)
            {
                _AnimTurret.SetTrigger("_IsDeath");
                boss._DestroyTurrets++;
                if (boss._DestroyTurrets == 2)
                {
                    boss.SecondPhase();
                    _EventPhases._EventPhases(true, 3, 1);
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.tag == "Player")
        {
            collidedObject.GetComponent<HealthSystem>().TakeDamage(damage);
            collidedObject.GetComponent<KnockBack>().DoKnockBack();
        }
    }

    public void SpawnBullet()
    {
        if (shootingTrigger)
        {
            Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
            _AnimTurret.SetTrigger("IsShooting");
        }
    }

    public void TurretMove()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.y < -UpAndDownEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.y > UpAndDownEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
}
    