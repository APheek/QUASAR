using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TutorialPlayer : MonoBehaviour
{
    public GameObject ActivateAnimation;
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
                StartCoroutine(SetTutorial());
            }
        }
    }

    IEnumerator SetTutorial()
    {
        ActivateAnimation.SetActive(true);
        yield return new WaitForSeconds(10);
        ActivateAnimation.SetActive(false);
        i = false;
    }

}
