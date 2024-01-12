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

    private void Start()
    {
        InvokeRepeating(nameof(SpawnBullet), 0, cooldownTime);
    }
    void SpawnBullet()
    {
        Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
    }
}
