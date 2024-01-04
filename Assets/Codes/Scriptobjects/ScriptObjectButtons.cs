using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptObjectButtons", menuName = "Codes/Scriptobjects", order = 1)]
public class ScriptObjectButtons : ScriptableObject
{
    [SerializeField] Sprite[] _ButtonPlay;
    [SerializeField] Sprite[] _ButtonOptions;
    [SerializeField] Sprite[] _ButtonHelp;
    [SerializeField] Sprite[] _ButtonInterfaceHelp;
    [SerializeField] Sprite[] _ButtonLeave;
    [SerializeField] Sprite[] _ButtonSound;
    public Sprite[] _buttonPlay
    {
        get
        {
            return _ButtonPlay;
        }
    }
    public Sprite[] _buttonOptions
    {
        get
        {
            return _ButtonOptions;
        }
    }
    public Sprite[] _buttonHelp
    {
        get
        {
            return _ButtonHelp;
        }
    }
    public Sprite[] _buttonInterfaceHelp
    {
        get
        {
            return _ButtonInterfaceHelp;
        }
    }
    public Sprite[] _buttonLeave
    {
        get
        {
            return _ButtonLeave;
        }
    }
    public Sprite[] _buttonSound
    {
        get
        {
            return _ButtonSound;
        }
    }
}
