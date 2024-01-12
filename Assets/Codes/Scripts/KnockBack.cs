using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    [SerializeField] float knockBackLength = 1.5f;
    [SerializeField] float knockBackForce = 30f;

    PlayerMovement playerMovement;
    Rigidbody2D rb;

    public bool IsHurt
    {
        get { return isHurt; }
    }

    bool isHurt = false;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void DoKnockBack()
    {
        StartCoroutine(DisablePlayerMovement(knockBackLength));
        rb.velocity = new Vector2(-playerMovement.FacingDirection * knockBackForce, knockBackForce);
    }

    IEnumerator DisablePlayerMovement(float time)
    {
        playerMovement.canMove = false;
        isHurt = true;
        yield return new WaitForSeconds(time);
        playerMovement.canMove = true;
        isHurt = false;
    }
}
