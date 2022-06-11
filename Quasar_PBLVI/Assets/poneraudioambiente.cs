using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poneraudioambiente : MonoBehaviour
{

    public AudioSource _ambiente;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            _ambiente.Play();



        }

    }


}
