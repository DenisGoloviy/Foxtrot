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
        if(_hp > 11)
        {
            _hp = 11;
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
        if (_hp == 11) 
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[0];
        }
        else if(_hp == 10) 
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("10");
        }
        else if (_hp == 9)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("9");
        }
        else if (_hp == 8)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("8");
        }
        else if (_hp == 7)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("7");
        }
        else if (_hp == 6)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("6");
        }
        else if (_hp == 5)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("5");
        }
        else if (_hp == 4)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("4");
        }
        else if (_hp == 3)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("3");
        }
        else if (_hp == 2)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("2");
        }
        else if (_hp == 1)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("1");
        }
        else if (_hp == 0)
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play("0");
        }
        ///////Stamina:
        if (_stamina == 9)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[9];
        }
        else if (_stamina == 8)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[8];
        }
        else if (_stamina == 7)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[7];
        }
        else if (_stamina == 6)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[6];
        }
        else if (_stamina == 5)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[5];
        }
        else if (_stamina == 4)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[4];
        }
        else if (_stamina == 3)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[3];
        }
        else if (_stamina == 2)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[2];
        }
        else if (_stamina == 1)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[1];
        }
        else if (_stamina == 0)
        {
            _STAMINABAR.sprite = _ScriptObjectInterface._staminabar[0];
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
