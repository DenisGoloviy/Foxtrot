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
    public int _stamina = 9;
    public Image _HPBAR;
    public Image _STAMINABAR;

    void Update()
    {
        _Help();
        _Bars();
    }

    void _Bars()
    {
        if(_hp > 10)
        {
            _hp = 10;
        }
        else if(_hp < 0) 
        {
            _hp = 0;
        }

        if(_stamina > 9) 
        {
            _stamina = 9;
        }
        else if(_stamina < 0)
        {
            _stamina = 0;
        }

        ///////HP:
        if (_hp == 10) 
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[0];
        }
        else 
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play(_hp.ToString());
        }

        ///////Stamina:
        _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[_stamina];


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
