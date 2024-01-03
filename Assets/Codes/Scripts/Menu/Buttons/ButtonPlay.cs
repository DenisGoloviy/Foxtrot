using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{
    public ScriptObjectButtons _ScriptObjectButtons;
    public void MouseCover()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _ScriptObjectButtons._buttonPlay[2];
    }
}
