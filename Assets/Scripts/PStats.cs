using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class PStats : MonoBehaviour
{
    public static int money;// static variables will persist over changing scenes.
    public int startMoney = 60;

    private void Start()
    {
        money = startMoney;
    }
}
