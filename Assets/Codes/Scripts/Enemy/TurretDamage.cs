using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDamage : MonoBehaviour
{
    public int damage = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.tag == "Player")
        {
            collidedObject.GetComponent<HealthSystem>().TakeDamage(damage);
            collidedObject.GetComponent<KnockBack>().DoKnockBack();
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
