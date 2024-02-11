using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestruction : MonoBehaviour
{
    Animator AnimBox;

    private void Start()
    {
        AnimBox = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            AnimBox.SetTrigger("Destroy");
            Destroy(collision.gameObject);
        }
    }
}
