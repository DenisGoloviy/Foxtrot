using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    public GameObject[] Windows;

    public HealthSystem health;

    private bool IsMenu;

    private void Update()
    {
        for(int i = 0; i < Windows.Length; i++)
        {
            if (health.health <= 0)
            {
                Windows[i].SetActive(false);
                Windows[1].SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Escape) && !IsMenu)
            {
                Windows[i].SetActive(false);
                Windows[2].SetActive(true);
                IsMenu = true;
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && IsMenu)
            {
                Windows[2].SetActive(false);
                Windows[0].SetActive(true);
                IsMenu = false;
            }
        }

    }
}
