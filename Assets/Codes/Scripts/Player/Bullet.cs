using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int time = 1;
    public GameObject gameobject;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void FixedUpdate()
    {
        Destroy(gameobject, time);
    }
}
