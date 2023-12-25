using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    bool iscan;
    public GameObject player;
    public GameObject dust;

    void Update()
    {
        if(Buttons._isOpened == true)
        {
            StartCoroutine(_dust());
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
    void Enter()
    {
        if (Input.GetKeyDown(KeyCode.E) && iscan == true)
        {
            SceneManager.LoadScene("Lvl2");
        }
    }
    IEnumerator _dust()
    {
        gameObject.GetComponent<Animator>().SetTrigger("IsOpened");
        yield return new WaitForSeconds(0.74f);
        dust.GetComponent<Animator>().SetTrigger("IsDust");
        Enter();
    }
}
