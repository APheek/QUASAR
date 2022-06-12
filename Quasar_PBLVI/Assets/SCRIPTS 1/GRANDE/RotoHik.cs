using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotoHik : MonoBehaviour
{
    CameraFollow camara;
    public Camera camarish;
    public bool _bandera;
   

    // Start is called before the first frame update
    void Start()
    {
        camara = camarish.GetComponent<CameraFollow>();
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
            _bandera = true ;
           



        }


    }



    private void OnTriggerExit(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {

        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "hikari") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
          
            _bandera = false;
            StartCoroutine(Waiting2());

        }


    }





    IEnumerator Waiting2() //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
    {

        Debug.Log("camarish");
        Vector3 position = Vector3.zero;
        position.y = 0.99f;
        position.x = -0.01173f;
        position.z = -2.82f;

        float duration = 4;

        for (float t = 0; t < duration; t += Time.deltaTime)
        {

            Vector3 smoothedPosition = Vector3.Lerp(camara.offset, position, 1f * Time.deltaTime);
            camara.offset = smoothedPosition;
            yield return null;

        }
        yield return null;

    }

}
