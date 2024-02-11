using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interface : MonoBehaviour
{
    public ScriptObjectInterface _ScriptObjectInterface;

    [Header("Help:")]
    public Image _E;
    public Image _SPACE;
    public Image _Q;
    public Image _LM;

    [Header("Bars:")]
    public Image _HPBAR;

    public HealthSystem health;

    [Header("Coins:")]
    public TextMeshProUGUI countCoin;
    public static float CountCoin = 0;

    void Update()
    {
        _Help();
        _Bars();
        countCoin.text = $"{CountCoin}";
    }

    void _Bars()
    {
        if(health.health > 10)
        {
            health.health = 10;
        }
        else if(health.health < 0) 
        {
            health.health = 0;
        }

        ///////HP:
        if (health.health == 10) 
        {
            _HPBAR.sprite = _ScriptObjectInterface._hpbar[0];
        }
        else 
        {
            _HPBAR.GetComponent<Animator>().enabled = true;
            _HPBAR.GetComponent<Animator>().Play(health.health.ToString());
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
