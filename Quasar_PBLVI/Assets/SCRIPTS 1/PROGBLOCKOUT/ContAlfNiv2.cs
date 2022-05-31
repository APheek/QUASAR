using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContAlfNiv2 : MonoBehaviour
{

    
    AlfombraNiv2 _scriptcontador;
    AlfombraNiv2 _scriptcontador1;
    AlfombraNiv2 _scriptcontador2;
    AlfombraNiv2 _scriptcontador3;

     public AudioSource _audioPuerta;

    //private float contaralfombras; 
    // Start is called before the first frame update
    void Start()
    {
        _scriptcontador = GameObject.FindGameObjectWithTag("alfombra").GetComponent<AlfombraNiv2>();
         _scriptcontador1 = GameObject.FindGameObjectWithTag("alfombra1").GetComponent<AlfombraNiv2>();
          _scriptcontador2 = GameObject.FindGameObjectWithTag("alfombra2").GetComponent<AlfombraNiv2>();
           _scriptcontador3 = GameObject.FindGameObjectWithTag("alfombra3").GetComponent<AlfombraNiv2>();

        // Destroy(gameObject,3);
    }

    // Update is called once per frame
    void Update()
    {
       

        destruirpuerta();
    }


    private void destruirpuerta(){

    if (_scriptcontador._contador && _scriptcontador1._contador  && _scriptcontador2._contador && _scriptcontador3._contador){

    _audioPuerta.Play();

    Destroy(gameObject);

    }




    }

}
