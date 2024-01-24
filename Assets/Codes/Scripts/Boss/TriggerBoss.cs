using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoss : MonoBehaviour
{
    bool Trigger;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Trigger = true;
            Debug.Log("Boss");
            Destroy(gameObject);
        }
    }
}
