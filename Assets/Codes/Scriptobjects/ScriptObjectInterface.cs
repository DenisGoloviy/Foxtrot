using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ScriptOjectInterface", menuName = "Codes/Scriptobjects", order = 1)]
public class ScriptObjectInterface : ScriptableObject
{
    [Header("Help:")]
    [SerializeField] Sprite[] _Help;

    [Header("Bars:")]
    [SerializeField] Sprite[] _HpBar;
    [SerializeField] Sprite[] _StaminaBar;

    public Sprite[] _help
    {
        get
        {
            return _Help;
        }
    }
    public Sprite[] _hpbar
    {
        get
        {
            return _HpBar;
        }
    }
    public Sprite[] _staminabar
    {
        get
        {
            return _StaminaBar;
        }
    }
}
