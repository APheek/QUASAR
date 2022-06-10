using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    AudioSource audioButton;

    void Start()
    {
        
    }

    public void PlaySound()
    {
        audioButton = GetComponent<AudioSource>();
        audioButton.Play(0);
        Debug.Log("started");
    }
   
}
