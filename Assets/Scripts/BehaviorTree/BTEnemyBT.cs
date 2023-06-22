using BehaviorTree;
using System.Collections.Generic;

public class BTEnemyBT : Tree
{
    public UnityEngine.Transform[] waypoints;

    public static float speed = 2.0f; 
    public static float fovRange = 6.0f;  
}
