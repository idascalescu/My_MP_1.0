using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//ACCESS NAV MESH

public abstract class GAction : MonoBehaviour
{
    public string actionName = "Action";
    public float cost = 1.0f;//Each action will have a cost.
    public GameObject target;//Location where the actions will take place.
    public string targetTag;//So you can pick up objects using the tag.
    public float duration;//Action duration.

    //Planner is going to match these back to back linked actions
    //They will take values from the Inspector
    public WorldState[] preConditions;
    public WorldState[] afterEffects;

    public NavMeshAgent agent;

    //++++++++++++++++++++++++++
    //Will actually contain values from the arrays above 
    public Dictionary<string, int> preconditions;
    public Dictionary<string, int> effects;
    //++++++++++++++++++++++++++

    public WorldStates agentBeliefs;//Internal set of states

    public bool running = false;//Set up the actions

    public GAction()
    {
        preconditions = new Dictionary<string, int>();
        effects = new Dictionary<string, int>();
    }

    public void Awake()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();

        if(preConditions != null) 
        {
            foreach(WorldState w in preConditions)
            {
                preconditions.Add(w.key, w.value);
            }
        }

        if (afterEffects != null)
        {
            foreach (WorldState w in afterEffects)
            {
                effects.Add(w.key, w.value);
            }
        }
    }

    public bool isAchievable()
    {
        return true;
    }

    public bool isAchievableGiven(Dictionary<string, int> conditions)
    {
        foreach (KeyValuePair<string, int> p in preconditions)
        {
            if (!conditions.ContainsKey(p.Key))
            {
                return false;
            }
            return true;
        }
        return true;
    }


    public abstract bool PrePerform();//To be inherited later
    public abstract bool PostPerform();//To be inherited later

}
