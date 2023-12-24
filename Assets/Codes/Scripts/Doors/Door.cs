using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    bool can;
    public GameObject player;

    void Update()
    {
        if(can && Buttons._isOpened == true && Input.GetKeyDown(KeyCode.E))
        {
            //SceneManager.LoadScene("Lvl2");
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collder)
    {
        if (player.tag == "Player")
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
