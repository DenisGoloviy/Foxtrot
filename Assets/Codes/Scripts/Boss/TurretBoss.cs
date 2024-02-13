using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBoss : MonoBehaviour
{

    public float speed = 3;
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
    TriggerBoss trigger;

    private void Update()
    {
        if (canMove)
        {
            TurretMove();
        }
    }

    private void Start()
    {
        InvokeRepeating(nameof(SpawnBullet), 0,cooldownTime);
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
                boss.UpdateDestroyedTurrets();
                Destroy(this);
            }
            print(gameObject.name);
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
    