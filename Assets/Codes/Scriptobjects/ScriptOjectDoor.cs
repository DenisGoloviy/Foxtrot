using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptOjectDoor", menuName = "Codes/Scriptobjects", order = 1)]
public class ScriptOjectDoor : ScriptableObject
{
    [SerializeField] Sprite[] _lightred;
    [SerializeField] Sprite[] _buttontred;

    public Sprite[] _Lightred
    {
        get
        {
            return _lightred;
        }
    }

    public Sprite[] _Buttontred
    {
        get
        {
            return _buttontred;
        }
    }
}
