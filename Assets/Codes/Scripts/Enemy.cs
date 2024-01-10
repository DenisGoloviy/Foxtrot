using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Transform[] patrolPoints;
    public int patrolDestination;

    public Transform playerPosition;
    private bool isChasing;
    public float chaseDistance;

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
            if(Vector2.Distance(transform.position, playerPosition.position) < chaseDistance)
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
}
