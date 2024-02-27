using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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
            Destroy(gameObject, 0.5f);
            Interface.CountCoin += 1;
        }
    }
}
