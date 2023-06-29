using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int maxPlayerHP = 100;
    public int currentHP;

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxPlayerHP;
        healthBar.SetMaxHealth(maxPlayerHP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        healthBar.SetHealth(currentHP);
    }
}
