using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Collections.AllocatorManager;

public class Button : MonoBehaviour
{
    public delegate void MyFunction();
    private MyFunction[] functions;

    ScriptObjectButtonButton ScriptObjectButtonButton;

    Sprite button;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            button = ScriptObjectButtonButton._buttonPlay[1];
        }
        else if(Input.GetMouseButtonUp(0))
        {

        }
    }
    void OnMouseOver()
    {

    }
}
