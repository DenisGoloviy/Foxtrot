using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDamage : MonoBehaviour
{
    public HealthSystem healthSystem;
    public int damage = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            healthSystem.TakeDamage(damage);
            collision.gameObject.GetComponent<KnockBack>().DoKnockBack();
            Destroy(gameObject);
        }
    }
}
