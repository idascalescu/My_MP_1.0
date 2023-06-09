using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld// sealed so could help in using QUEUES // Remove the conflicts when we acces one thing/time
{
    private static readonly GWorld instance = new GWorld();//Singleton
    private static WorldStates world;//Dictionary holder

    static GWorld()//CONSTRUCTOR
    {
        world = new WorldStates();//A new dictionary
    }
    
    private GWorld()//Acces this with a singleton
    {    
    }

    public static GWorld Instance//
    {
        get 
        { 
            return instance; 
        }
    }

    public WorldStates GetWorld()//Returns the status of the world
    { return world; }
}
