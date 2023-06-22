using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WorldState//To be used later for dictionaries.
{
    public string key;
    public int value;
}
public class WorldStates
{
    public Dictionary<string, int> states;//This will hold the states of the world.
    public WorldStates()//STATES CONSTRUCTOR
    {
        states = new Dictionary<string, int> ();//SET UP FOR DICTIONARY
    }

    //++++++++++++++++++++++++++++++++++++++++++
    //Methods that use and modify the Dictionary.
    public bool HasState(string key)
    {
        return states.ContainsKey(key);
    }

    void AddState(string key, int value) 
    {
        states.Add(key, value);
    }
    
    public void ModifyState(string key, int value)
    {
        if (states.ContainsKey(key))
        {
            states[key] += value;
            if (states[key] <= 0)
                RemoveState(key);
        }
        else
            states.Add(key, value);
    }

    public void RemoveState(string key) 
    {
        if (states.ContainsKey(key))
            states.Remove(key);
    }

    public void SetState(string key, int value)
    {
        if(states.ContainsKey(key))
            states[key] = value;
        else 
            states.Add(key, value);
    }
    //++++++++++++++++++++++++++++++++++++++++++

    public Dictionary<string, int> GetStates()//Returns all of the states / The Dictionary
    {
        return states;
    }
}
