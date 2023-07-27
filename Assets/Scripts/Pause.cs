using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : UnityEngine.MonoBehaviour
{
    public GameObject ui;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);

        if(ui.activeSelf)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }
}
//https://www.youtube.com/watch?v=789gM9R3htc&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=21
//Infinite thanks to Brackeys
