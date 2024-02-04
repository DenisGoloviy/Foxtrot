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
    public float cooldownTime = 2f;
    public Transform shootingPoint;
    public int turretHP = 30;
    public Shooting shooting;
    TriggerBoss trigger;

    public bool canMove = false;

    private void Start()
    {
        //InvokeRepeating(nameof(SpawnBullet), 0, cooldownTime);
    }
    void SpawnBullet()
    {
            Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
    }

    private void Update()
    {
        if(canMove)
        {
            TurretMove();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            turretHP -= shooting.damage;
            if (turretHP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.tag == "Player")
        {
            collidedObject.GetComponent<HealthSystem>().TakeDamage(damage);
            print(damage);
            collidedObject.GetComponent<KnockBack>().DoKnockBack();
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
    