using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BossFightTurret : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootingPoint;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 2)
        {
            timer = 0;
            Shoot();
        }

        void Shoot()
        {
            Instantiate(bullet, shootingPoint.position, Quaternion.identity);
        }
    }
}
