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
        for (int i = 0; i < Stars.Length; i++)
        {
            switch(Points)
            {
                case 0:
                    Stars[i].GetComponent<SpriteRenderer>().sprite = StarSprite[1];
                    break;
                case 1:
                    Stars[0].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
                    break;
                case 2:
                    Stars[1].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
                    break;
                case 3:
                    Stars[2].GetComponent<SpriteRenderer>().sprite = StarSprite[0];
                break;
            }

        }
    }
}
