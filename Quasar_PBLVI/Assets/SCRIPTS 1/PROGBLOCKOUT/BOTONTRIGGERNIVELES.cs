using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BOTONTRIGGERNIVELES : MonoBehaviour
{
    Controller _inputHandler;
public Vector3 offset;
public Vector3 caca;
    public Transform _boton;
    public Transform _checkpoint;
    public Transform _player;
    private bool _bandera;
    public float contadorbotones;

    SaltarParedes _saltarparedes;
    // Start is called before the first frame update
    void Start()
    {
        _saltarparedes = GameObject.FindGameObjectWithTag("Player").GetComponent<SaltarParedes>();
        _saltarparedes.enabled = true;
         _inputHandler = GetComponent<Controller>();
         _bandera= false;
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
        if (other.gameObject.tag == "Player") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
             _bandera = true;
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
            
        _bandera= false;
           
        }


    }

    private void darlealboton(){

    if (_bandera){
        if (_inputHandler._boton){
             Vector3 position = (_boton.localPosition);
 position.y = (_boton.localPosition).y;
 position.x = (_boton.localPosition).x;
  position.z = (_boton.localPosition + offset).z;


  _boton.localPosition = position;
  _saltarparedes.enabled = false;
  iracheckpoint();
 _inputHandler._boton = false;

 Invoke("volverposicionboton", 0.2f);
             }
    }

    }




    private void volverposicionboton(){
        Vector3 position = (_boton.localPosition);
 position.y = (_boton.localPosition).y;
 position.x = (_boton.localPosition).x;
  position.z = (_boton.localPosition - offset).z;


  _boton.localPosition = position;
  _saltarparedes.enabled = true;
  
    }





private void iracheckpoint(){


    Debug.Log("estoyeniracheck");

    Debug.Log(_player.transform.position);
     Debug.Log(_checkpoint.localPosition);
  
       //_player.position = new Vector3(_checkpoint.position.x, _checkpoint.position.y, _checkpoint.position.y);
       _player.transform.position = _checkpoint.transform.position;
       Debug.Log("aqui he llegado");
       _inputHandler._boton=false;
        //Vector3 smoothedPosition = Vector3.Lerp (transform.position, position, smoothSpeed *Time.deltaTime);
 //transform.position = smoothedPosition;

 //transform.LookAt(target);



}





}

