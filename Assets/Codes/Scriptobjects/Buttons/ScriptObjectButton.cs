using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptObjectButton : ScriptableObject
{
    [SerializeField] Sprite[] _ButtonPlay;
    [SerializeField] Sprite[] _ButtonLeave;
    [SerializeField] Sprite[] _ButtonSetting;
    [SerializeField] Sprite[] _ButtonHelp;
    [SerializeField] Sprite[] _ButtonLoud;

    public Sprite[] _buttonPlay
    {
        get
        {
            return _ButtonPlay;
        }
    }
    public Sprite[] _buttonLeave
    {
        get
        {
            return _ButtonLeave;
        }
    }
    public Sprite[] _buttonSetting
    {
        get
        {
            return _ButtonSetting;
        }
    }
    public Sprite[] _buttonHelp
    {
        get
        {
            return _ButtonHelp;
        }
    }
    public Sprite[] _buttonLoud
    {
        get
        {
            return _ButtonLoud;
        }
    }
}
