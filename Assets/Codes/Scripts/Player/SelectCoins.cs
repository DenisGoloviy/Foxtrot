using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class SelectCoins : MonoBehaviour
{
    private Animator CoinAnimator;

    private void Start()
    {
        CoinAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            CoinAnimator.SetTrigger("Destroy");
            Invoke(nameof(Destroy), 0.5f);
            Interface.CountCoin += 00001;
        }
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
}
