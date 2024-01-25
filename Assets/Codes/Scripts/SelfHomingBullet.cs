using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfHomingBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public int damage = 2;
    public HealthSystem healthSystem;
    public KnockBack knockBack;

    public float bulletSpeed = 15f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            healthSystem.TakeDamage(damage);
            knockBack.DoKnockBack();
            Destroy(gameObject);
        }
    }
}
