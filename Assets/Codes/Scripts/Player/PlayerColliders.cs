using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColliders : MonoBehaviour
{
    Collider2D PlayerCollider;
    public Collider2D[] Collider;
    void Start()
    {
        for (int i = 0; i < Collider.Length; i++)
        {
            PlayerCollider = gameObject.GetComponent<Collider2D>();
            Physics2D.IgnoreCollision(PlayerCollider, Collider[i]);
        }
    }
}
