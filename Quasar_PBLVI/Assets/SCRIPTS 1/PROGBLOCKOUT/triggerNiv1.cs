using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerNiv1 : MonoBehaviour
{

public bool _banderatriggerNiv1;
 public Transform _player;
    // Start is called before the first frame update
    void Start()
    {
        _banderatriggerNiv1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



        private void OnTriggerEnter(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "Player") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
             _banderatriggerNiv1 = true;
           //Vector3 position = (transform.localPosition);  
        Debug.Log("he entrado en el trigger del boton");
       // float newz = 0.1f; 
       // _boton.localPosition
        //  Vector3 newPositionButton = Vector3.Lerp (transform.position, position, smoothSpeed *Time.deltaTime);
       // transform.localPosition.z = (transform.position.z+z);

       
        
       
        }

    }



        private void OnTriggerExit(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "Player") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
            
        _banderatriggerNiv1= false;
           
        }


    }
}
