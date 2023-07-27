using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorTree;

public class BTGoToFinish : BTNode
{
    private Transform _transform;

    public BTGoToFinish (Transform transform)
    {
        _transform = transform;
    }

    public override NodeState Evaluate()
    {
        Transform target = (Transform)GetData("target");
        if (Vector3.Distance(_transform.position, 
            target.position) > 0.01f)
        {
            _transform.position = Vector3.MoveTowards(
            _transform.position, target.position, 
            BehhaviorTreeEnm.speed + Time.deltaTime);
        }

        state = NodeState.WALKING;
        return state;
    }
}
//https://www.youtube.com/watch?v=aR6wt5BlE-E&t=629s YOU BEAUTIFUL CREATURE, THIS IS FOR BT !!!!! 
// To implement enemy attacking soon !!!!!!!!!!!!!!
