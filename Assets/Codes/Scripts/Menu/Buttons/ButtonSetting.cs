using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSetting : MonoBehaviour
{
    public ScriptObjectButtons _ScriptObjectButtons;

    void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonOptions[0];
    }
    void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonOptions[1];
    }
    void OnMouseUpAsButton()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonOptions[2];
    }
}
