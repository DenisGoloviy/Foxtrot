using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    bool isCan;
    public GameObject dust;
    public Buttons button;

    public int Scene;

    void Update()
    {
        if(button._isOpened == true)
        {
            gameObject.GetComponent<Animator>().SetTrigger("IsOpened");
            Invoke(nameof(Dest), 0.65f);
            Enter();
        }
    }

    private void OnTriggerEnter2D(Collider2D collder)
    {
        Debug.Log("OnTriggerEnter2D");
        if (collder.gameObject.tag == "Player")
        {
            isCan = true;
            Debug.Log("Player");
        }
    }
    private void OnTriggerExit2D(Collider2D collder)
    {
        if (collder.gameObject.tag == "Player")
        {
            isCan = false;
        }
    }
    void Enter()
    {
        Debug.Log(isCan);
        if (Input.GetKeyDown(KeyCode.E) && isCan == true)
        {
            SceneManager.LoadScene(Scene);
        }
    }

    void Dest()
    {
        dust.GetComponent<Animator>().SetTrigger("IsDust");
    }
}
