using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoss : MonoBehaviour
{
    public bool Trigger = false;

    public GameObject DoorTrigger;

    public Boss boss;

    TurretBoss turret;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Trigger = true;
            Debug.Log("Boss");
            Destroy(gameObject);
            DoorTrigger.SetActive(true);
            boss.StartPhase();
            turret.canMove = true;
        }
    }
}
