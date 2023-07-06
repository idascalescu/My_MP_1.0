using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTCollisions : MonoBehaviour
{
    [SerializeField]
    float health = 0.0f;
    [SerializeField]
    float maxHealth = 10.0f;

    [SerializeField]
    HealthBarBT healthBarBT;

    private void Awake()
    {
        healthBarBT = GetComponentInChildren<HealthBarBT>();
        
    }

    private void Start()
    {
        healthBarBT.UpdateHealthBar(health, maxHealth);
        Debug.Log("bar has been updated ... ");
        health = maxHealth;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("BT got hit");
            BTTakeDamage(1.0f);
            Destroy(collision.gameObject);
        }
    }

    public void BTTakeDamage(float damageAmount)
    {
        healthBarBT.UpdateHealthBar(health, maxHealth);
        
        health -= damageAmount;
        if(health <= 0)
        {
            GetDistroyed();
        }
    }

    private void GetDistroyed()
    {
        Destroy(gameObject);
    }
}
