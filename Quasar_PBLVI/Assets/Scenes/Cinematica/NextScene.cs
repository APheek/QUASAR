using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    
   // public GameObject videoPlayer;
    public float timeToStop;
    void Start()
    {
        StartCoroutine(Change());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Change()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene(0);
    }
}
