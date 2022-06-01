using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlfombraNiv2 : MonoBehaviour
{
     public MeshRenderer MeshRenderer;
private bool _bandera;


public bool _contador;
    // Start is called before the first frame update
    void Start()
    {
        _contador = false;
    }

    // Update is called once per frame
    void Update()
    {

    //Debug.Log(_contador);
        ChangeColor();
    }



    private void OnTriggerEnter(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "arrastrar") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
             _bandera = true;
           //Vector3 position = (transform.localPosition);  
        Debug.Log("he entrado en el trigger del boton");
       // float newz = 0.1f; 
       // _boton.localPosition
        //  Vector3 newPositionButton = Vector3.Lerp (transform.position, position, smoothSpeed *Time.deltaTime);
       // transform.localPosition.z = (transform.position.z+z);

        _contador = true;
        
       
        }

    }



        private void OnTriggerExit(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "arrastrar") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
            
        _bandera= false;
            
    _contador = false;
    
        }


    }




    private void ChangeColor()
    {
        if (_bandera){
       /*_whenDidItHappen = Time.time; //Time.time tiempo que ha pasado desde que ha comenzado el juego.
        float rdm = Random.Range(0f, 1f);
        float rdm1 = Random.Range(0f, 1f);
        float rdm2 = Random.Range(0f, 1f);*/ //Si no hacemos esto y los ponemos todos igual solo nos saldrá una escala de grises
       Color newColor = new Color(0, 255, 0);
         MeshRenderer.material.color = newColor;
        
        //_whenDidItHappen = Time.time;
        
    }


    else if (!_bandera){

    Color newColor = new Color(255, 0, 0);
    MeshRenderer.material.color = newColor;
   
    }
}


}
