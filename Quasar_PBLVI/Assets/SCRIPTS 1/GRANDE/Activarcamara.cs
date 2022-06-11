using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activarcamara : MonoBehaviour
{
    CameraFollow camara;
    public Camera camarish;


    ContadorCamara Contador;


  
    public int valor;
    // Start is called before the first frame update
    void Start()
    {
        camara = camarish.GetComponent<CameraFollow>();
        Contador = GameObject.FindGameObjectWithTag("ContCam").GetComponent<ContadorCamara>();
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {

            Contador.contador = valor;


        }

    }
}
