using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
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

    public GameObject[] WindowButton;

    public ButtonArrayType buttonType;

    private bool IsLoud;

    private bool IsClick;

    private void OnMouseUpAsButton()
    {
        if(buttonType == ButtonArrayType.Loud && IsLoud == false)
        {
            SoundTrack.Audio(-80);
            IsLoud = true;
        }
        else if(buttonType == ButtonArrayType.Loud && IsLoud == true)
        {
            SoundTrack.Audio(0);
            IsLoud = false;
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
        if(IsWork)
        {
            SceneManager.LoadScene(1);
        }
    }
    private void HelpType(bool IsWork)
    {
        if(IsWork)
        {
            ////
        }
    }
    private void SettingType(bool IsWork)
    {
        if(IsWork)
        {
            for (int i = 0; i < WindowButton.Length; i++)
            {
                WindowButton[i].SetActive(false);
                WindowButton[1].SetActive(true);
            }
        }
    }
    private void LeaveType(bool IsWork)
    {
        if(IsWork)
        {
            Application.Quit();
        }
    }
    private void LeaveDeathType(bool IsWork)
    {
        if(IsWork)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void BackMenuType(bool IsWork)
    {
        if(IsWork)
        {
            for (int i = 0; i < WindowButton.Length; i++)
            {
                WindowButton[i].SetActive(false);
            }
            WindowButton[0].SetActive(true);
        }
    }
    public void LoudType(bool IsWork)
    {
        IsClick = IsWork;
    }
}
