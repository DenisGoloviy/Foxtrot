using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBoss : MonoBehaviour
{
    public float speed = 3;
    public float UpAndDownEdge;

    public void TurretMove()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.y < -UpAndDownEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.y > UpAndDownEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
}
