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

    private void Update()
    {
        foreach (GameObject star in Stars)
        {
            star.GetComponent<SpriteRenderer>().sprite = StarSprite[1];
        }
        for(int i = 0; i < Stars.Length; i++)
        {
            if (Interface.CountCoin >= (i+1)*10)
            {
                Stars[i].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
            }
        }

        //for (int i = Stars.Length - 1; i >= 0; i--)
        //{
        //    switch(Interface.CountCoin)
        //    {
        //        case int n when (Interface.CountCoin < 10):
        //            Stars[i].GetComponent<SpriteRenderer>().sprite = StarSprite[1];
        //            break;
        //        case int n when (Interface.CountCoin >= 10 && Interface.CountCoin < 20):
        //            Stars[i-2].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
        //            break;
        //        case int n when (Interface.CountCoin >= 20 && Interface.CountCoin < 30):
        //            Stars[i-1].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
        //            break;
        //        case 30:
        //            Stars[i].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
        //        break;
        //    }
        //}
    }
}
