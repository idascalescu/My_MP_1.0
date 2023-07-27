using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public abstract class Tree : UnityEngine.MonoBehaviour
    {
        public BTNode _root = null;//Changed _root into public
                                  //so can be accesed from BehaviorTreeEnm

        protected void Start()
        {
            _root = SetupTree();
        }

        private void Update()
        {
            if(_root != null)
            {
                _root.Evaluate();
            }
        }

        protected abstract BTNode SetupTree();
    }
}
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1729?f1url=%3FappId%3Droslyn%26k%3Dk(CS1729)
// FOR DEBUGGING
