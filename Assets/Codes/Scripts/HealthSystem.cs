using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    private Animator _Body;

    public Interface _Interface;
    void Start()
    {
        health = maxHealth;
        _Body = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        _Interface._hp -= damage;
        if (health <= 0)
        {
            _Body.SetTrigger("Death");
        }
    }
}
