using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

[System.Serializable]
public class PStats : MonoBehaviour
{
    public static int money;// static variables will persist over changing scenes.

    public int startMoney = 75;

    private void Start()
    {
        money = startMoney;
    }
}
