using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool WaveisOver;

    public GameObject waveCompleteLevelUI;

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

    }

    public void LoadLevel1()
    {

    }

    public void LoadLevels()
    {
        SceneManager.LoadScene("LevelsScene");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void WaveFinished()
    {
        WaveisOver = true; 
        waveCompleteLevelUI.SetActive(true);

    }
}
