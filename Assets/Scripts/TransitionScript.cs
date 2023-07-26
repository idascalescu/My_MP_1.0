using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    private void Update()
    {
        if(PStats.enemiesDown >= 1)
        {
            ToTransitionScene();
        }
    }

    public void ToTransitionScene()
    {
        SceneManager.LoadScene("TransitionScene");
    }
}
