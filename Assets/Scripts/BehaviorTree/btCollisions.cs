using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class BTCollisions : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public HealthBarBT healthBarBT;

    GoapSpawner goapSpawner;

    private GameObject anyEnemy;

    NavMeshAgent agent;

    private void Start()
    {
        health = maxHealth;
        healthBarBT.SetMaxHealthBT(maxHealth);
        anyEnemy = GameObject.FindGameObjectWithTag("Enemy");
        agent = GetComponent<NavMeshAgent>();   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            BTTakeDamage(5.0f);
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "SlowingBullet")
        {
            BTTakeDamage(0.5f);
            agent.speed = 2.0f;
        }

        if (collision.gameObject.tag == "FastBulletPrefab")
        {
            BTTakeDamage(3.2f);
        }
    }

    public void BTTakeDamage(float damageAmount)
    {
        health -= damageAmount;
        healthBarBT.SetHealthBT(health);
        if (health <= 0)
        {
            GetDestroyed();
            PStats.money += 5;
            /*goapSpawner.numberGoapEnemies--;*/
        }
    }

    public void GetDestroyed()
    {
        Destroy(gameObject);
    }
}
