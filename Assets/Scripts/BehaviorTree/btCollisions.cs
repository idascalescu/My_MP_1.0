using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BTCollisions : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public HealthBarBT healthBarBT;

    GoapSpawner goapSpawner;

    private GameObject anyEnemy;

    NavMeshAgent agent;

    private AudioSource audioSource;
    public AudioClip enemyHit;

    TransitionScript transitionScript;
    private void Start()
    {
        health = maxHealth;
        healthBarBT.SetMaxHealthBT(maxHealth);
        anyEnemy = GameObject.FindGameObjectWithTag("Enemy");
        agent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
    }

    private void LateUpdate()
    {
        if (PStats.enemiesDown == 2)
        {
            TransitionToScene();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            BTTakeDamage(3.9f);
            Destroy(collision.gameObject);
            
            audioSource.clip = enemyHit;
            audioSource.Play();
        }

        if(collision.gameObject.tag == "SlowingBullet")
        {
            BTTakeDamage(0.3f);
            agent.speed = 2.0f;
            
            audioSource.clip = enemyHit;
            audioSource.Play();
        }

        if (collision.gameObject.tag == "FastBulletPrefab")
        {
            BTTakeDamage(1.2f);
            
            audioSource.clip = enemyHit;
            audioSource.Play();
        }
    }

    public void BTTakeDamage(float damageAmount)
    {
        health -= damageAmount;
        healthBarBT.SetHealthBT(health);
        if (health <= 0)
        {
            GetDestroyed();
            /*audioSource.clip = coinCollected; audioSource.Play();*/
            PStats.money += 5;
            PStats.enemiesDown += 1;
            Debug.Log("They#re down..");
        }
    }

    public void GetDestroyed()
    {
        Destroy(gameObject, 1.0f);
    }

    /*private void CoinHasBeenCollected() // Didn't work :(
    {
        audioSource.clip = coinCollected;
        Debug.Log("sing for me");
        audioSource.Play();
    }*/

    public void TransitionToScene()
    {
        SceneManager.LoadScene("TransitionScene");
    }
}
//https://forum.unity.com/threads/cannot-play-a-disabled-audio-source.468084/
