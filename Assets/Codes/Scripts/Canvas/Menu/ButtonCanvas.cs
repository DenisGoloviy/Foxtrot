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

    public void IsClick()
    {
        SpriteButton.GetComponent<Image>().sprite = ScriptObjectButton._buttonLeave[0];
        SceneManager.LoadScene(0);
    }
    public void IsNotClick()
    {
        SpriteButton.GetComponent<Image>().sprite = ScriptObjectButton._buttonLeave[1];
    }
    public void IsOnButton()
    {
        SpriteButton.GetComponent<Image>().sprite = ScriptObjectButton._buttonLeave[2];
    }

}
