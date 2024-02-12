using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPhaseEnemy : MonoBehaviour
{
    public float moveSpeed = 1f;

    public Transform playerPosition;

    public int enemyHP = 10;
    public Shooting shooting;

    private Animator EnemyAnimator;

    void Start()
    {
        EnemyAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (transform.position.x > playerPosition.position.x)
        {
            transform.localScale = new Vector3(8, 8, 8);
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (transform.position.x < playerPosition.position.x)
        {
            transform.localScale = new Vector3(-8, 8, 8);
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
