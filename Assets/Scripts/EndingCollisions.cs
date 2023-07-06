using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class EndingCollisions : MonoBehaviour
{
    public int maxHP = 0;
    public int currentHP;

    public HealthBar healthBar;

    void Start()
    {
        currentHP = maxHP;
        healthBar.SetMaxHealth(maxHP);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("BT Reached finnish");
            TakeDamage(1);
            Destroy(collision.gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        
        currentHP -= 10;
        healthBar.SetHealth(currentHP);
        Debug.Log("asd");
    }
}
//https://www.youtube.com/watch?v=BLfNP4Sc_iA tutorial for HP bar 
