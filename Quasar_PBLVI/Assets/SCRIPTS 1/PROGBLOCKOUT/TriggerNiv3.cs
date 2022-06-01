using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNiv3 : MonoBehaviour
{
public GameObject puerta;
private bool _bandera;
public Transform _boton;
public Vector3 offset;
 public AudioSource _audioPuerta;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(puerta,3) ;
    }

    // Update is called once per frame
    void Update()
    {
        darlealboton();
    }


    
    private void OnTriggerEnter(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "Objeto") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
             _bandera = true;
           //Vector3 position = (transform.localPosition);  
        Debug.Log("he entrado en el trigger del boton");
       // float newz = 0.1f; 
       // _boton.localPosition
        //  Vector3 newPositionButton = Vector3.Lerp (transform.position, position, smoothSpeed *Time.deltaTime);
       // transform.localPosition.z = (transform.position.z+z);
        _audioPuerta.Play();
       Destroy(puerta);
        
       
        }

    }



        private void OnTriggerExit(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "Objeto") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
            
        _bandera= false;
           
        }


    }
    private void darlealboton(){

    if (_bandera){
        
             Vector3 position = (_boton.localPosition);
 position.y = (_boton.localPosition).y;
 position.x = (_boton.localPosition+offset).x;
  position.z = (_boton.localPosition).z;


  _boton.localPosition = position;
  

 Invoke("volverposicionboton", 0.2f);
             
    }

    }




    private void volverposicionboton(){
        Vector3 position = (_boton.localPosition);
 position.y = (_boton.localPosition).y;
 position.x = (_boton.localPosition - offset).x;
  position.z = (_boton.localPosition).z;


  _boton.localPosition = position;
  
  
    }

}
