using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Collections.AllocatorManager;
using UnityEngine.UI;

public class ButtonCanvas : MonoBehaviour
{
    public ScriptObjectButton ScriptObjectButton;

    public Image SpriteButton;

    public void OnMouseUpAsButton()
    {
        print("1");
        SpriteButton.GetComponent<Image>().sprite = ScriptObjectButton._buttonLeave[0];
    }
    public void IsNotClick()
    {
        print("2");
        SpriteButton.GetComponent<Image>().sprite = ScriptObjectButton._buttonLeave[1];
    }
    public void IsOnButton()
    {
        print("3");
        SpriteButton.GetComponent<Image>().sprite = ScriptObjectButton._buttonLeave[2];
    }

}
