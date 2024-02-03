using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    public ScriptObjectButtons _ScriptObjectButtons;

    void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonPlay[2];
    }
    void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonPlay[0];
    }
    void OnMouseUpAsButton()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonPlay[1];
        SceneManager.LoadScene("Lvl1");
    }
}
