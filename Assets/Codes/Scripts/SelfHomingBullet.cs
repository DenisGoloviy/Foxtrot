using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfHomingBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;

    public float bulletSpeed = 15f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * bulletSpeed;
    }
}
