using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TutorialPlayer : MonoBehaviour
{
    public VideoPlayer VideoTutorial;
    private bool i;
    void Start()
    {
        VideoTutorial = GetComponent<VideoPlayer>();
        i = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (i == true)
            {
                PlayAnimation();
            }
        }
    }

    private void PlayAnimation()
    {
        VideoTutorial.Play();
        i = false;
    }
}
