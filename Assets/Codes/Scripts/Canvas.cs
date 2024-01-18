using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    public GameObject Interface;
    public GameObject Death;

    public Interface _Interface;

    private void Update()
    {
        if(_Interface._hp == 0)
        {
            Interface.SetActive(false);
            Death.SetActive(true);
        }
        else if(_Interface._hp > 0)
        {
            Interface.SetActive(true);
            Death.SetActive(false);
        }
    }
}
