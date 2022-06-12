using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotoHik2 : MonoBehaviour
{
    // Start is called before the first frame update
   
   
    public bool _bandera;


    // Start is called before the first frame update
    void Start()
    {
        
        _bandera = false;

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        // PRUEBA = true;
        // Debug.Log("estoydentrodeltrigger444444444444");
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "hikari") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {

            Debug.Log("Hikari is on the air");
            _bandera = true;




        }


    }



    private void OnTriggerExit(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {

        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "hikari") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {

            _bandera = false;
           

        }


    }





    
}
