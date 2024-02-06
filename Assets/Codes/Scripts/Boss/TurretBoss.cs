using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBoss : MonoBehaviour
{
    ShootingTrigger shootingTrigger;
    public float speed = 3;
    public float UpAndDownEdge;
    public HealthSystem healthSystem;
    public int damage = 4;
    public GameObject bullet;
    public float cooldownTime = 2f;
    public Transform shootingPoint;
    public int turretHP = 30;
    public Shooting shooting;
    public bool canMove;

    private void Update()
    {
        if (canMove)
        {
            TurretMove();
        }

        SpawnBullet();
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
            collidedObject.GetComponent<KnockBack>().DoKnockBack();
        }
    }

    void SpawnBullet()
    {
        if (shootingTrigger.shootingTrigger)
        {
            Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
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
    