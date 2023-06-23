using System.Collections;
using System.Collections.Generic;
using BehaviorTree;
using UnityEngine;

public class CheckHealPlaceInRange : BTNode
{
    private static int _enemyLayerMask = 1 << 6;

    private Transform _transform;

    public CheckHealPlaceInRange(Transform transform)
    {
        _transform = transform;
    }

    public override NodeState Evaluate()
    {
        object t = GetData("target");
        if (t == null)
        {
            Collider[] _colliders = Physics.OverlapSphere(
                _transform.position, BehhaviorTreeEnm.fovRange, _enemyLayerMask);

            if (_colliders.Length > 0)
            {
                parent.parent.SetData("target", _colliders[0].transform);
                state = NodeState.SUCCESS;
                return state;
            }

            state = NodeState.FAILURE;
            return state;
        }
        state = NodeState.SUCCESS;
        return state;
    }
}
