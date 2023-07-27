using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;

public class TimerScript : MonoBehaviour
{
    private float timeDuration = 3.0f * 60.0f;

    [SerializeField]
    private bool countDown = true;

    private float timer;

    [SerializeField]
    private TextMeshProUGUI firstMinute;

    [SerializeField]
    private TextMeshProUGUI secondMinute;

    [SerializeField]
    private TextMeshProUGUI separator;

    [SerializeField]
    private TextMeshProUGUI firstSecond;

    [SerializeField]
    private TextMeshProUGUI secondSecond;

    private float flashTimer;
    private float flashDuration = 1.0f;

    public bool thirtySecondsPassed;

    private void Start()
    {
        ResetTimer();   
    }

    private void Update()
    {
        if (countDown && timer > 0)
        {
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        } 
        else if (!countDown && timer < timeDuration)
        {
            timer += Time.deltaTime;
            UpdateTimerDisplay(timer);
        }
        else
        {
            Flash();
        }
    }

    private void ResetTimer()
    {
        if (countDown)
        {timer = timeDuration;}
        else
        {
            timer = 0.0f;
        }
        SetTextDisplay(true);
    }

    public void UpdateTimerDisplay(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        firstMinute.text = currentTime[0].ToString();
        secondMinute.text = currentTime[1].ToString();
        firstSecond.text = currentTime[2].ToString();
        secondSecond.text = currentTime[3].ToString();

        /*if (currentTime[3] == 30)
        {
            thirtySecondsPassed = true;
        }*/ //Part of the waves system - Tried to implement that but failed with grace :)
    }

    private void Flash()
    {
        if(!countDown && timer != timeDuration ) 
        {
            timer = 0;
            UpdateTimerDisplay(timer);
        }

        if(flashTimer <= 0.0f)
        {
            flashTimer = flashDuration;
        }
        else if(flashTimer >= flashDuration /2)
        {
            flashTimer -= Time.deltaTime;
            SetTextDisplay(false);
        }
        else
        {
            flashTimer -= Time.deltaTime;
            SetTextDisplay(true);
        }
    }

    private void SetTextDisplay(bool enabled)
    {
        firstMinute.enabled = enabled;
        secondMinute.enabled = enabled;
        separator.enabled = enabled;
        firstSecond.enabled = enabled;
        secondSecond.enabled = enabled;
    }
}
//https://www.youtube.com/watch?v=27uKJvOpdYw&ab_channel=AIA
// half credits to Brackeys ____ another half to AIA
//The canvas is from the TD tutorial made by brackeys
//The script is from the link above
