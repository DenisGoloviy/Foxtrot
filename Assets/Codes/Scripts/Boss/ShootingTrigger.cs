using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTrigger : MonoBehaviour
{
    public bool shootingTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        shootingTrigger = true;
    }
}
