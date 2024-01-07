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
            StartCoroutine(_dust());
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
    IEnumerator _dust()
    {
        gameObject.GetComponent<Animator>().SetTrigger("IsOpened");
        yield return new WaitForSeconds(0.74f);
        dust.GetComponent<Animator>().SetTrigger("IsDust");
        Enter();
    }
}
