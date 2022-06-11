using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Romper_plataforma : MonoBehaviour
{
    public AudioSource _romperelsuelo;
    public GameObject Destroyed;

    
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
            Debug.Log("raito dentro");


            Instantiate(Destroyed, transform.position, transform.rotation);
            Destroy(gameObject);
            _romperelsuelo.Play();



        }

    }




}
