using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    bool iscan;
    public GameObject player;
    void Update()
    {
        if(Buttons._isOpened == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && iscan == true)
            {
                SceneManager.LoadScene("Lvl2");
            }
            gameObject.GetComponent<Animator>().SetTrigger("IsOpened");
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
