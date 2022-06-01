using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presion_botones : MonoBehaviour
{
    // Start is called before the first frame update
    Controller _inputHandler;
    BotonTrigger _scriptboton;

    void Start()
    {
         _inputHandler = GetComponent<Controller>();
         _scriptboton = GameObject.FindGameObjectWithTag("boton").GetComponent<BotonTrigger>();
        _scriptboton.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_inputHandler._boton){
            _scriptboton.enabled = true;
         //_inputHandler._boton=false;
         
            }

            else{
                _scriptboton.enabled = false;
            }
    }
}
