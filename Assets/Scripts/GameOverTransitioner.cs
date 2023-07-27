using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTransitioner : MonoBehaviour
{
    private void Update()
    {
        /*if(PStats.levelTwoEnemiesDown == 1)
        {
            ActivateGameOver();
        }*/
    }

    public void ActivateGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}


