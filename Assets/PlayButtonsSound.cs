using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonsSound : MonoBehaviour
{
    public AudioSource playSound;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayOnButtonClicked()
    {
        playSound.Play();
    }
}
