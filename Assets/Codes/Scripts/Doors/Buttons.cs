    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public static bool _isOpened;
    public GameObject player;
    public bool can;

    void Update()
    {
        if(can == true && Input.GetKeyDown(KeyCode.E))
        {
            _isOpened = true;
        }
        else
        {
            _isOpened = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collder)
    {
        if(player.tag == "Player")
        {
            can = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collder)
    {
        if (player.tag == "Player")
        {
            can = false;
        }
    }
}
