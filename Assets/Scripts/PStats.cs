using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class PStats : MonoBehaviour
{
    public static int money;// static variables will persist over changing scenes.
    public static int enemiesDown;
    
    public int startMoney = 75;

    private void Start()
    {
        money = startMoney;
    }
}
