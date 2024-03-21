using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health;

    private Animator _Body;

    public Interface _Interface;
    void Start()
    {
        _Body = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            _Body.SetTrigger("Death");
        }
    }
}
