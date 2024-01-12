using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Transform playerPosition;
    public Transform enemyPosition;
    public float KBForce = 15f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(playerPosition.position.x <= enemyPosition.position.x)
            {
                playerMovement.rb.velocity = new Vector2(KBForce, KBForce);
            }
            if (playerPosition.position.x >= enemyPosition.position.x)
            {
                playerMovement.rb.velocity = new Vector2(-KBForce, KBForce);
            }
        }
    }
}
