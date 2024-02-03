using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeaveDeath : MonoBehaviour
{
    public ScriptObjectButtons _ScriptObjectButtons;

    void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonLeave[0];
    }
    void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonLeave[1];
    }
    void OnMouseUpAsButton()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonLeave[2];
    }
}
