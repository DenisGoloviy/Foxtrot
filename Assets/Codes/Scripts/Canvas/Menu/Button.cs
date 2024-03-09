using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Collections.AllocatorManager;

public enum ButtonArrayType
{
    Play,
    Setting,
    Leave,
    Help,
    LeaveDeath,
    BackMenu,
    Loud,
    Promt
}

public class Button : MonoBehaviour
{
    public ScriptObjectButton ScriptObjectButton;

    public GameObject SpriteButton;

    private Sprite[] currentButton;
    private Sprite[] currentButtonSetting;

    public GameObject[] WindowButton;

    public ButtonArrayType buttonType;

    private bool IsClick;

    private void OnMouseUpAsButton()
    {
        switch(IsClick)
        {
            case true:
                print("T");
                SpriteButton.GetComponent<SpriteRenderer>().sprite = currentButtonSetting[2];
                break;
            case false:
                print("F");
                SpriteButton.GetComponent<SpriteRenderer>().sprite = currentButtonSetting[3];
                break;
        }
        SwitchButton(false);
        SpriteButton.GetComponent<SpriteRenderer>().sprite = currentButton[2];
    }
    private void OnMouseEnter()
    {
        SwitchButton(false);
        SpriteButton.GetComponent<SpriteRenderer>().sprite = currentButton[1];
    }
    private void OnMouseExit()
    {
        SwitchButton(false);
        SpriteButton.GetComponent<SpriteRenderer>().sprite = currentButton[2];
    }
    private void OnMouseDown()
    {
        SwitchButton(true);
        SpriteButton.GetComponent<SpriteRenderer>().sprite = currentButton[0];
    }

    private void SwitchButton(bool IsWork)
    {
        switch (buttonType)
        {
            case ButtonArrayType.Play:
                currentButton = ScriptObjectButton._buttonPlay;
                PlayType(IsWork);
                break;
            case ButtonArrayType.Setting:
                currentButton = ScriptObjectButton._buttonSetting;
                SettingType(IsWork);
                break;
            case ButtonArrayType.Leave:
                currentButton = ScriptObjectButton._buttonLeave;
                LeaveType(IsWork);
                break;
            case ButtonArrayType.Help:
                currentButton = ScriptObjectButton._buttonHelp;
                HelpType(IsWork);
                break;
            case ButtonArrayType.LeaveDeath:
                currentButton = ScriptObjectButton._buttonLeave;
                LeaveDeathType(IsWork);
                break;
            case ButtonArrayType.BackMenu:
                currentButton = ScriptObjectButton._buttonLeave;
                BackMenuType(IsWork);
                break;
            case ButtonArrayType.Loud:
                currentButtonSetting = ScriptObjectButton._buttonLoud;
                currentButton = ScriptObjectButton._buttonLoud;
                LoudType(IsWork);
                break;
            default:
                print("No buttons");
                break;
        }
    }
    private void PlayType(bool IsWork)
    {
        switch(IsWork)
        {
            case true:
                SceneManager.LoadScene(1);
                break;
        }
    }
    private void HelpType(bool IsWork)
    {
        switch (IsWork)
        {
            case true:
                ////
                break;
        }
    }
    private void SettingType(bool IsWork)
    {
        switch (IsWork)
        {
            case true:
                for(int i = 0; i < WindowButton.Length; i++)
                {
                    WindowButton[i].SetActive(false);
                    WindowButton[1].SetActive(true);
                }
                break;
        }
    }
    private void LeaveType(bool IsWork)
    {
        switch (IsWork)
        {
            case true:
                Application.Quit();
                break;
        }
    }
    private void LeaveDeathType(bool IsWork)
    {
        switch (IsWork)
        {
            case true:
                SceneManager.LoadScene(0);
                break;
        }
    }
    private void BackMenuType(bool IsWork)
    {
        switch (IsWork)
        {
            case true:
                for (int i = 0; i < WindowButton.Length; i++)
                {
                    WindowButton[i].SetActive(false);
                    WindowButton[0].SetActive(true);
                }
                break;
        }
    }
    private void LoudType(bool IsWork)
    {
        switch (IsWork)
        {
            case true:
                IsClick = true;
                break;
            case false:
                IsClick = false;
                break;
        }
    }
}
