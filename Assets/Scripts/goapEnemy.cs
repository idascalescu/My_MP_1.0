using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goapEnemy : GAgent
{
    protected override void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("Finish", 1, true);
        goals.Add(s1, 3);
    }   
}
