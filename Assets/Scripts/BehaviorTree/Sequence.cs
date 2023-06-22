using System.Collections;using System.Collections.Generic;

namespace BehaviorTree
{
    public class Selector : BTNode
    {
        public Selector() : base() { }
        public Selector(List<BTNode> children) : base(children) { }
        public override NodeState Evaluate()
        {
            bool anyChildIsRunning = false;

            foreach (BTNode node in children)
            {
                switch (node.Evaluate())
                {
                    case NodeState.FAILURE:
                        state = NodeState.FAILURE;
                        return state;
                    case NodeState.SUCCESS:
                        continue;
                    case NodeState.WALKING:
                        anyChildIsRunning = true;
                            continue;
                    default:
                        state = NodeState.SUCCESS;
                            return state;
                }
            }

            state = anyChildIsRunning ? NodeState.WALKING : NodeState.FAILURE;
            return state;
        }
    }
}

