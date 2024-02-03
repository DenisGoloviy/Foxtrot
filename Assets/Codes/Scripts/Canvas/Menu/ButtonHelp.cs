using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHelp : MonoBehaviour
{
    public ScriptObjectButtons _ScriptObjectButtons;

    void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonHelp[1];
    }
    void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonHelp[0];
    }
    void OnMouseUpAsButton()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonHelp[2];
    }
}
