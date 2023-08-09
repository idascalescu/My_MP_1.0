using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyUI : MonoBehaviour
{
    BTCollisions btCollisions;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI numberOfEnemiesDown;

    [HideInInspector]
    public static int enemiesDown;

    void Update()
    {
        moneyText.text = PStats.money.ToString() + " GOLD";
        numberOfEnemiesDown.text = enemiesDown.ToString() + " Points";
    }
}
