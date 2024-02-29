using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float leftAndRight;
    public Transform[] patrolPoints;
    private int patrolDestination = 1;
    public Boss boss;

    public Transform playerPosition;
    private bool isChasing;
    public float chaseDistance;

    public int enemyHP = 10;
    public Shooting shooting;

    private Animator EnemyAnimator;

    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        EnemyAnimator = GetComponent<Animator>();
    }
    void Update()
    {
            if (isChasing)
            {
                if (transform.position.x > playerPosition.position.x)
                {
                    transform.localScale = new Vector3(-8, 8, 8);
                    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
                }
                if (transform.position.x < playerPosition.position.x)
                {
                    transform.localScale = new Vector3(8, 8, 8);
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

                if (patrolDestination == 0)
                {
                    transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
                    if (Vector2.Distance(transform.position, patrolPoints[0].position) < .3f)
                    {
                        transform.localScale = new Vector3(8, 8, 8);
                        patrolDestination = 1;
                    }
                }
                if (patrolDestination == 1)
                {
                    transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
                    if (Vector2.Distance(transform.position, patrolPoints[1].position) < .3f)
                    {
                        transform.localScale = new Vector3(-8, 8, 8);
                        patrolDestination = 0;
                    }
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
                Destroy(gameObject, 1);
                boss.CountEnemy++;
                if (boss.currentSceneName == "LvlBoss" && boss.CountEnemy == 2)
                {
                    SceneManager.LoadScene(6);
                }
            }
        }
    }
}
