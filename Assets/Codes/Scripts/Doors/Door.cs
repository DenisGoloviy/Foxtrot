using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool iscan;
    public GameObject player;

    void Update()
    {
        if (Buttons._isOpened == true && Input.GetKeyDown(KeyCode.E) && iscan == true)
        {
            //SceneManager.LoadScene("Lvl2");
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collder)
    {
        if (player.tag == "Player")
        {
            iscan = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collder)
    {
        if (player.tag == "Player")
        {
            iscan = false;
        }
    }
}
