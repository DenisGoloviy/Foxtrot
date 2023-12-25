using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public static bool _isOpened;
    public GameObject player;
    public GameObject Door;
    bool can;

    public ScriptOjectDoor _ScriptOjectDoor;
    void Update()
    {
        if(can == true && Input.GetKeyDown(KeyCode.E))
        {
            _isOpened = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptOjectDoor._Buttontred[1];
            Door.GetComponent<SpriteRenderer>().sprite = _ScriptOjectDoor._Lightred[1];
        }
    }

    void OnTriggerEnter2D(Collider2D collder)
    {
        if(player.tag == "Player")
        {
            can = true;
        }
    }
    void OnTriggerExit2D(Collider2D collder)
    {
        if (player.tag == "Player")
        {
            can = false;
        }
    }
}
