using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoss : MonoBehaviour
{
    public GameObject DoorTrigger;

    public Boss boss;

    public EventPhases _EventPhases;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Boss");
            Destroy(gameObject);
            DoorTrigger.SetActive(true);
            boss.StartPhase();
            _EventPhases._EventPhases(true, 3, 0);
        }
    }
}
