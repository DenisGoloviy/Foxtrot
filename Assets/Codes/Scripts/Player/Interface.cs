using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    public ScriptObjectInterface _ScriptObjectInterface;

    [Header("Help:")]
    public Image _E;
    public Image _SPACE;
    public Image _Q;
    public Image _LM;

    [Header("Bars:")]
    public int _hp = 11;
    public int _stamina = 10;
    public Image _HPBAR;
    public Image _STAMINABAR;

    void Update()
    {
        _Help();
        _Bars();
    }

    void _Bars()
    {
        if(_hp > 11)
        {
            _hp = 11;
        }
        else if(_hp < 0) 
        {
            _hp = 0;
        }

        if(_stamina > 10) 
        {
            _stamina = 10;
        }
        else if(_stamina < 0)
        {
            _stamina = 0;
        }

        if(_hp == 11) 
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[0];
        }
        else if(_hp == 10) 
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[1];
        }
        else if (_hp == 9)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[2];
        }
        else if (_hp == 8)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[3];
        }
        else if (_hp == 7)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[4];
        }
        else if (_hp == 6)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[5];
        }
        else if (_hp == 5)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[6];
        }
        else if (_hp == 4)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[7];
        }
        else if (_hp == 3)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[8];
        }
        else if (_hp == 2)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[9];
        }
        else if (_hp == 1)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[10];
        }
        else if (_hp == 0)
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[11];
        }
    }
    void _Help()
    {
        if(Input.GetKey(KeyCode.E))
        {
            _E.sprite = _ScriptObjectInterface._help[4];
        }
        else
        {
            _E.sprite = _ScriptObjectInterface._help[0];
        }

        if (Input.GetKey(KeyCode.Q))
        {
            _Q.sprite = _ScriptObjectInterface._help[6];
        }
        else
        {
            _Q.sprite = _ScriptObjectInterface._help[2];
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _SPACE.sprite = _ScriptObjectInterface._help[7];
        }
        else
        {
            _SPACE.sprite = _ScriptObjectInterface._help[3];
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            _LM.sprite = _ScriptObjectInterface._help[5];
        }
        else
        {
            _LM.sprite = _ScriptObjectInterface._help[1];
        }
    }
}
