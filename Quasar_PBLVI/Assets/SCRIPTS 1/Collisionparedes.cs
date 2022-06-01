using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionparedes : MonoBehaviour
{

    Controller _inputHandler;
    // Start is called before the first frame update
    void Start()
    {
        _inputHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("estoy colisionando");
        if (collision.gameObject.tag == "Player") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
           
            _inputHandler.puedegirar = false;
        }
    }
    }
