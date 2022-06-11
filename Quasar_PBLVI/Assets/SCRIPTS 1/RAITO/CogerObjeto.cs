using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CogerObjeto : MonoBehaviour
{
      //CharacterController _characterController;
    Controller _inputHandler;
    public GameObject _handpoint;
    public GameObject _handpause;
    public GameObject _handend;
    public GameObject _handexit;
    private GameObject pickedObject = null;
    private bool bandera;


    //ANIMACIONES
    public bool COGER;
    public bool SOLTAR;

    public AudioSource _audiocoger;
    public AudioSource _audiosoltar;

    // public GameObject _handpoint2;



    void Start()
    {
        //_characterController = GetComponent<CharacterController>();
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        bandera = false;


  //  _posicionharta =   pickedObject.GetComponent<Rigidbody>();

    }


    
    void Update()
    {
        Debug.Log(bandera);
     if(bandera == true)
        {
            StopCoroutine(MakeSequenceExit());
        }
        tirar(false);
    }


   private void OnTriggerStay(Collider other){
        
       
        if (other.gameObject.CompareTag("Objeto")){
            _inputHandler._puedocoger = true;
            //Debug.Log("coger");    
            //  Debug.Log(_inputHandler._coger);
            //Debug.Log("objeto");
            //Debug.Log(pickedObject==null);
            if ((_inputHandler._coger) && (pickedObject==null)){
                
                COGER = true;
              // Debug.Log("cogido");
               other.GetComponent<Rigidbody>().useGravity = false; 

               other.GetComponent<Rigidbody>().isKinematic = true;
                StartCoroutine(MakeSequence());
                StartCoroutine(Waiting(0.8f, _audiocoger));
               
                other.transform.position = _handpoint.transform.position;

                
                other.gameObject.transform.SetParent(_handpoint.gameObject.transform);
              

                pickedObject = other.gameObject;



               


            }


       }



   }


   IEnumerator MakeSequence()
    //void MakeSequence()Asi las hace todas jutas y no sirve
    {
        
        _handpoint.transform.localPosition = _handpause.transform.localPosition;
        Vector3 myVector = _handend.transform.localPosition;
        yield return new WaitForSeconds(1.27f);
        //LO SIGUIENTE ES PARA USAR SIEMPRE LA MISMA FUNCION.

        yield return StartCoroutine(SetPosition(0.6f, myVector));

        yield return null;

       
    }




    IEnumerator SetPosition(float duration, Vector3 position) //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
    {
        // Vector3 handpointt = _handpoint.transform.localPosition;
        Debug.Log("ESTOY DENTRO DE POSITION");
        Vector3 startpose = _handpoint.transform.localPosition;
        Vector3 endpos = position;
        //float duration = 2f;
        for (float t = 0; t < duration; t += Time.deltaTime)
        {
             float x = Mathf.Clamp01(t / duration); //Sabemos que está entre 0 y 1. 
             float f = 3 * Mathf.Pow(x, 2) - 2 * Mathf.Pow(x, 3); //Suaviza la curva, solo sirve entre 0 y 1. 
            _handpoint.transform.localPosition = Vector3.Lerp(startpose, endpos, f);
            
            yield return null;
        }

        _handpoint.transform.localPosition = endpos;

        if (_handpoint.transform.localPosition == endpos && !_inputHandler._coger)
        {
            tirar(true);
        }

        // _handpoint.transform.localPosition = endpos; //sin esto, nunca llegaria al tamaño que le ponemos realmente porque se haría por aproximaciones. 

    }

    IEnumerator MakeSequenceExit()
    //void MakeSequence()Asi las hace todas jutas y no sirve
    {
        // _handpoint.transform.localPosition = _handpause.transform.localPosition;
       
        Debug.Log("Voy a soltarlo");
        Vector3 exit = _handexit.transform.localPosition;
        //yield return new WaitForSeconds(1.27f);
        //LO SIGUIENTE ES PARA USAR SIEMPRE LA MISMA FUNCION.

        yield return StartCoroutine(SetPosition(0.45f, exit));

        //yield return new WaitForSeconds(0.1f);
        Debug.Log("La bandera esta en " + bandera);
       // bandera = true;
        Debug.Log("La bandera AHORA esta en " + bandera);
        yield return new WaitForSeconds(0.1f);
        // tirar();

        //Debug.Log("hola");
        //yield return null;

    }

    private void tirar(bool boleana)
    {
        bandera = boleana;
        if (pickedObject != null)
        {
            //Debug.Log("no soy null");
            if (!_inputHandler._coger)
            {

                Debug.Log("cogerno");

                COGER = false;
                SOLTAR = true;




                StartCoroutine(MakeSequenceExit());

                // StopCoroutine(MakeSequenceExit());
                // Debug.Log("despues de la corrutina");

                if (bandera == true)
                {
                    _audiosoltar.Play();
                    bandera = false;
                    Debug.Log("estoy dentro del true");
                    pickedObject.GetComponent<Rigidbody>().isKinematic = false;

                    pickedObject.gameObject.transform.SetParent(null);
                    //Vector3 posicionhartaa= new Vector3 (0,0,0);
                    //_posicionharta.transform.position= posicionhartaa;
                    pickedObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500f, ForceMode.Acceleration);
                    pickedObject.GetComponent<Rigidbody>().useGravity = true;
                    pickedObject = null;
                    _inputHandler._puedocoger = false;

                    Debug.Log("estoy apuntito de acabar el true");

                }
                Debug.Log("AHORITA MISMO LA BANDERA ESTA EN" + bandera);

                

                Debug.Log("AHORAZA MISMITO LA BANDERA ESTA EN" + bandera);
            }






        }

        }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Objeto"))
        {

            _inputHandler._puedocoger = false;
        }



    }

    IEnumerator Waiting(float duration, AudioSource audio) //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
    {

        yield return new WaitForSeconds(duration);
        audio.Play();


    }

}



    
