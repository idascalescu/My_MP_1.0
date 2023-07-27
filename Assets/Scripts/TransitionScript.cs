using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour//This script was an attempt to transit a scene after another 
                                            //but for simplicity I have decided to select the levels
                                           //from the "LevelsScene" :/
{
    private void Update()
    {
        if(PStats.enemiesDown == 1) { TransitionToScene(); }
    }

    public void TransitionToScene()
    {
        SceneManager.LoadScene("TransitionScene");
    }
}
