using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyUI : UnityEngine.MonoBehaviour
{
    BTCollisions btCollisions;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI numberOfEnemiesDown;

    void Update()
    {
        moneyText.text = PStats.money.ToString() + " GOLD";
        numberOfEnemiesDown.text = BTCollisions.destroyedEnemies.ToString() + " Points";
    }
}
