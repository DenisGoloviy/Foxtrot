using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ScriptOjectInterface", menuName = "Codes/Scriptobjects", order = 1)]
public class ScriptObjectInterface : ScriptableObject
{
    [Header("Help:")]
    [SerializeField] Sprite[] _Help;

    public Sprite[] _help
    {
        get
        {
            return _Help;
        }
    }
}
