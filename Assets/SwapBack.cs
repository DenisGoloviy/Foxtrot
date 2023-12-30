using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapBack : MonoBehaviour
{
    public GameObject fox1;
    public Transform fox2Pos;
    public GameObject fox2;
    private bool fox2Active = true;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && fox2Active)
        {
            Instantiate(fox1, fox2Pos.position, fox2Pos.rotation);
            Destroy(fox2);
            fox2Active = false;
        }
    }
}
