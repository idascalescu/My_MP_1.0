using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public enum NodeState
    {
        WALKING,
        SUCCESS,
        FAILURE
    };


    public class BTNode
    {
        protected NodeState state;

        public BTNode parent;
        protected List<BTNode> children = new List<BTNode>();

        private Dictionary<string, 
            object> _dataContext = 
            new Dictionary<string, object>();

        public BTNode()
        {
            parent = null;
        }

        public BTNode(List<BTNode> children)
        {
            foreach(BTNode child in children)
            {
                Attach(child);
            }
        }

        public void Attach(BTNode node)
        {
            node.parent = this;
            children.Add(node);
        }

        public virtual NodeState Evaluate() => NodeState.FAILURE;//Node system
                                                                //Part of behaviour tree
                                                               //This will sort the task for the NPC

        public void SetData(string heal, object value)
        {
            _dataContext[heal] = value;
        }

        public object GetData(string heal)
        {
            object value = null;
            if (_dataContext.TryGetValue(heal, out value))
                return value;

            BTNode node = parent;
            while (node != null)
            {
                value = node.GetData(heal);
                if (value != null)
                    return value;
                node = node.parent;
            }
            return null;
        }
        public bool ClearData(string heal)
        {
            if (_dataContext.ContainsKey(heal))
                return true;

            BTNode node = parent;
            while (node != null)
            {
                bool cleared = node.ClearData(heal);
                if (cleared)
                    return true;
                node = node.parent;
            }
            return false;
        }
    }
}
