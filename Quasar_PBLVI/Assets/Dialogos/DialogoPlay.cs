using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoPlay : MonoBehaviour
{
    public AudioSource Prompt;
    public GameObject TextoDialogo;
    public int timePrompt;
    private bool i;
    void Start()
    {
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
                StartCoroutine(DialogoStuff());
            }
        }
    }

    IEnumerator DialogoStuff()
    {
        Prompt.Play(0);
        TextoDialogo.SetActive(true);
        yield return new WaitForSeconds(timePrompt);
        TextoDialogo.SetActive(false);
        i = false;
  
    }
}
