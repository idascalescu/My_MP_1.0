using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

using UnityEngine.UI;

public class BTCollisions : MonoBehaviour//This scriptthas a bit of to many functions. . .
                                        //It works, but must be optimised and splitted in two different scripts
                                       //Or maybe three. . .
{
    public float health;
    public float maxHealth;

    public HealthBarBT healthBarBT;

    GoapSpawner goapSpawner;

    private GameObject anyEnemy;

    NavMeshAgent agent;

    private AudioSource audioSource;
    public AudioClip coinCollected;
    public AudioClip enemyHit;

    public static int destroyedEnemies;

    private void Start()
    {
        health = maxHealth;
        healthBarBT.SetMaxHealthBT(maxHealth);
        anyEnemy = GameObject.FindGameObjectWithTag("Enemy");
        agent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            BTTakeDamage(3.9f);
            audioSource.clip = enemyHit;
            audioSource.Play();
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "SlowingBullet")
        {
            BTTakeDamage(0.3f);
            agent.speed = 3.3f;
            
            audioSource.clip = enemyHit;
            audioSource.Play();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "FastBulletPrefab")
        {
            BTTakeDamage(1.2f);
            
            audioSource.clip = enemyHit;
            audioSource.Play();
            Destroy(collision.gameObject);
        }
    }

    public void BTTakeDamage(float damageAmount)
    {
        health -= damageAmount;
        healthBarBT.SetHealthBT(health);
        if (health <= 0)
        {
            /*CoinHasBeenCollected();*/
            GetDestroyed();
            destroyedEnemies += 1;
            /*audioSource.clip = coinCollected; audioSource.Play();*/
            PStats.money += 5;
            /*PStats.enemiesDown += 1;*/
        }
    }

    public void GetDestroyed()
    {
        Destroy(gameObject);
    }

    /*private void CoinHasBeenCollected() // Didn't work :( :/ :| \: ):
    {
        audioSource.clip = coinCollected;
        Debug.Log("sing for me");
        audioSource.Play();
    }*/

}
//https://forum.unity.com/threads/cannot-play-a-disabled-audio-source.468084/
