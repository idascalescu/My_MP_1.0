using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : UnityEngine.MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevels()
    {
        SceneManager.LoadScene("LevelsScene");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void LoadTransLevel1()
    {
        SceneManager.LoadScene("TransitionSceneLevel1");
    }

    public void LoadTransLevel2()
    {
        SceneManager.LoadScene("TransitionSceneLevel2");
    }
}
// 
