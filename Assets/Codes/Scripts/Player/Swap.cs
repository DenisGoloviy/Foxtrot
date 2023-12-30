using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public GameObject fox2;
    public Transform fox1Pos;
    public GameObject fox1;
    private bool fox1Active = true;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && fox1Active)
        {
            Instantiate(fox2, fox1Pos.position, fox1Pos.rotation);
            Destroy(fox1);
            fox1Active = false;
        }
    }
}
