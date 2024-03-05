using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class END : MonoBehaviour
{
    public GameObject[] Stars;
    public Sprite[] StarSprite;

    public int Points;

    private void Update()
    {
        Interface.CountCoin = Points;
        for (int i = Stars.Length - 1; i >= 0; i--)
        {
            switch(Interface.CountCoin)
            {
                case int n when (Interface.CountCoin < 10):
                    Stars[i].GetComponent<SpriteRenderer>().sprite = StarSprite[1];
                    break;
                case int n when (Interface.CountCoin >= 10 && Interface.CountCoin < 20):
                    Stars[i-2].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
                    break;
                case int n when (Interface.CountCoin >= 20 && Interface.CountCoin < 30):
                    Stars[i-1].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
                    break;
                case 30:
                    Stars[i].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
                break;
            }

        }
    }
}
