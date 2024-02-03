using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    public GameObject Interface;
    public GameObject Death;

    public Interface _Interface;

    public HealthSystem health;

    private void Update()
    {
        if(health.health <= 0)
        {
            Interface.SetActive(false);
            Death.SetActive(true);
        }
        else
        {
            Interface.SetActive(true);
            Death.SetActive(false);
        }
    }
}
