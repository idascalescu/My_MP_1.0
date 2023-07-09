using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTCollisions : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public HealthBarBT healthBarBT;

    private void Start()
    {
        health = maxHealth;
        healthBarBT.SetMaxHealthBT(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            BTTakeDamage(20);
            Destroy(collision.gameObject);
        }
    }

    public void BTTakeDamage(int damageAmount)
    {
        health -= damageAmount;
        healthBarBT.SetHealthBT(health);
        if (health <= 0)
        {
            GetDestroyed();
        }
    }

    public void GetDestroyed()
    {
        Destroy(gameObject);
    }
}
