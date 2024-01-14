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
            StartCoroutine(Destroy());
        }
    }
    IEnumerator Destroy()
    {
        CoinAnimator.SetTrigger("Destroy");
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
