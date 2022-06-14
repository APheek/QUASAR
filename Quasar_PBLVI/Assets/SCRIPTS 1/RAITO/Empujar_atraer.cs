using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Empujar_atraer : MonoBehaviour
{
    //CharacterController _characterController;
    Controller _inputHandler;
    public GameObject _handpoint;
    private GameObject pickedObject = null;
    SaltarParedes saltarparedes;
    public bool EMPUJAR;
    public bool Arrastrando_objeto;

    // public GameObject _handpoint2;



    void Start()
    {
        saltarparedes = GameObject.FindGameObjectWithTag("Player").GetComponent<SaltarParedes>();
        EMPUJAR = false;
        //_characterController = GetComponent<CharacterController>();
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        Arrastrando_objeto = false;

        //  _posicionharta =   pickedObject.GetComponent<Rigidbody>();

    }



    void Update()
    {

       // Debug.Log("El arrastrar objeto esta " + Arrastrando_objeto);

        if (pickedObject != null)
        {
            //Debug.Log("no soy null");
            if (!_inputHandler._coger)
            {
                EMPUJAR = false;
                _inputHandler._puedocoger = false;
                Debug.Log("cogerno");

                Arrastrando_objeto = false;

                pickedObject.GetComponent<Rigidbody>().isKinematic = false;

                pickedObject.gameObject.transform.SetParent(null);
                //Vector3 posicionhartaa= new Vector3 (0,0,0);
                //_posicionharta.transform.position= posicionhartaa;
                //pickedObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500f, ForceMode.Acceleration);
                pickedObject.GetComponent<Rigidbody>().useGravity = true;
                pickedObject = null;


            }

        }



    }


    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("arrastrar"))
        {

            _inputHandler._puedocoger = true;

          ///////////////  Debug.Log("arrastrar");    
          // Debug.Log(_inputHandler._coger);
          //Debug.Log("objeto");
          //Debug.Log(pickedObject==null);
            if ((_inputHandler._coger) && (pickedObject == null))
            {
                EMPUJAR = true;
                saltarparedes.speed = 1;
                Arrastrando_objeto = true;
                Debug.Log("cogido");
                other.GetComponent<Rigidbody>().useGravity = false;

                other.GetComponent<Rigidbody>().isKinematic = true;

               // other.transform.position = _handpoint.transform.position;

                other.gameObject.transform.SetParent(_handpoint.gameObject.transform);

                pickedObject = other.gameObject;






            }

         


        }



    }



    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("arrastrar"))
        {

            _inputHandler._puedocoger = false;
        }



    }




}
