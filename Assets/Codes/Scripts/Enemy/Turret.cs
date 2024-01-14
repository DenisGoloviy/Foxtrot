using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public HealthSystem healthSystem;
    public int damage = 2;
    public GameObject bullet;
    public float cooldownTime = 1.5f;
    public Transform shootingPoint;
    public int enemyHP = 10;
    public Shooting shooting;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnBullet), 0, cooldownTime);
    }
    void SpawnBullet()
    {
        Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            enemyHP -= shooting.damage;
            if (enemyHP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
