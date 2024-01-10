using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bullet;
    public int damage = 2;
    public Enemy enemy;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(bullet);
            enemy.enemyHP -= damage;
            if (enemy.enemyHP <= 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
