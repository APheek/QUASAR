using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNiv4 : MonoBehaviour
{
public GameObject puerta;
private bool _bandera;
public Transform _boton;
public Vector3 offset;
Controller _inputHandler;
public AudioSource _audioPuerta;
public bool PRUEBA;
public bool CHISPA;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(puerta,3) ;
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        _bandera = false;
       // PRUEBA = false;
    }

    // Update is called once per frame
    void Update()
    {
        darlealboton();
    }


    
    private void OnTriggerEnter(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
       // PRUEBA = true;
       // Debug.Log("estoydentrodeltrigger444444444444");
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "Player") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
            _bandera = true;
            _inputHandler._puedopulsarlo=true;
            darlealboton();
        }
         

    }



        private void OnTriggerExit(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "Player") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
            _inputHandler._puedopulsarlo=false;
        _bandera= false;
           
        }


    }




   
    private void darlealboton(){

    if (_bandera){
        
           if(_inputHandler._boton){
            
             CHISPA = true;
           //Vector3 position = (transform.localPosition);  
      //  Debug.Log("he entrado en el trigger del boton");
       // float newz = 0.1f; 
       // _boton.localPosition
        //  Vector3 newPositionButton = Vector3.Lerp (transform.position, position, smoothSpeed *Time.deltaTime);
       // transform.localPosition.z = (transform.position.z+z);
       _audioPuerta.Play();
       Destroy(puerta);
       _bandera=false;
          
       _inputHandler._chispa = false;
       Invoke("volverposicionboton", 0.2f);
        }
         //CHISPA = false;
             
    }

    }




    private void volverposicionboton(){
        CHISPA = false;
  
    }

}
