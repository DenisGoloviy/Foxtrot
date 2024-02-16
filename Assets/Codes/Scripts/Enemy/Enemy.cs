using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float leftAndRight;

    public Transform playerPosition;
    private bool isChasing;
    public float chaseDistance;

    public int enemyHP = 10;
    public Shooting shooting;

    private Animator EnemyAnimator;

    public bool secondPhaseisActive;

    void Start()
    {
        EnemyAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (!secondPhaseisActive)
        {
            if (isChasing)
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
                if (Vector2.Distance(transform.position, playerPosition.position) > chaseDistance)
                {
                    isChasing = false;
                }
            }
            else
            {
                if (Vector2.Distance(transform.position, playerPosition.position) < chaseDistance)
                {
                    isChasing = true;
                }

                Vector3 pos = transform.position;
                pos.x += moveSpeed * Time.deltaTime;
                transform.position = pos;
                if (pos.x < -leftAndRight)
                {
                    moveSpeed = Mathf.Abs(moveSpeed);
                }
                else if (pos.x > leftAndRight)
                {
                    moveSpeed = -Mathf.Abs(moveSpeed);
                }
            }
        }
        else if (secondPhaseisActive)
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            enemyHP -= shooting.damage;
            if (enemyHP <= 0)
            {
                EnemyAnimator.SetTrigger("Destroy");
                Invoke(nameof(Destroy), 1);
            }
        }
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }
}
