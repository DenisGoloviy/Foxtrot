using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptObjectButtonButton : ScriptableObject
{
    [SerializeField] Sprite[] _Button;

    public Sprite[] _button
    {
        get
        {
            return _Button;
        }
    }
}
