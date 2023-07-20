using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBT : MonoBehaviour
{
    /*[SerializeField] private Slider slider;

    public void UpdateHealthBar(float currentValue, float maxValue)
    {
        slider.value = currentValue / maxValue;
    }*/
    // Implemented this from Brakeys Tutorial for Tower Defense
    // As a try to fix the previous unresponsive one 
    public Slider btSlider;
    public Image fill;

    public void SetMaxHealthBT(int health)
    {
        btSlider.maxValue = health;
        btSlider.value = health;
    }

    public void SetHealthBT(int health)
    {
        btSlider.value = health;
    }
}
// https://www.youtube.com/watch?v=_lREXfAMUcE

