using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBoss : MonoBehaviour
{
    public float speed = 3;
    public Transform[] points;
    public int i;

    public void TurretMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, points[i].position) < 0.2f)
        {
            if (i > 0)
            {
                i = 0;
            }
            else
            {
                i = 0;
            }
        }
    }
}
