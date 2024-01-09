using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public HealthSystem healthSystem;
    public int damage = 2;
    public GameObject bullet;
    public float cooldownTime = 1.5f;
    public Transform shootingPoint;

    private void Update()
    {
        cooldownTime -= 1 * Time.deltaTime;

        if (cooldownTime <= 0f)
        {
            Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);

            cooldownTime = 1.5f;
        }
    }
}
