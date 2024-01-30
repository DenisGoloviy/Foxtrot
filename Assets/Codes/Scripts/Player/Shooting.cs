using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bullet;
    public int damage = 2;
    public PlayerMovement playerMovement;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && playerMovement.fox1Active)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
    }
}
