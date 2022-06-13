using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CAMBIARHIK : MonoBehaviour
{
    CharacterController _characterController;
    Controller _inputHandler;
    VolarHik _volarhik;
    Volar_Bosque _volarbosque;
    SaltarParedes _saltarparedes;
   HikariFollow _scriptseguirhikari;
    Caminar_bosque _movementbosque;





    public bool cambiarcaminar;

    // Start is called before the first frame update
    void Start()
    {
        _scriptseguirhikari = GameObject.FindGameObjectWithTag("hikari").GetComponent<HikariFollow>();
       _volarhik = GameObject.FindGameObjectWithTag("hikari").GetComponent<VolarHik>();
        _volarbosque = GameObject.FindGameObjectWithTag("hikari").GetComponent<Volar_Bosque>();
        _saltarparedes = GetComponent<SaltarParedes>();
        _movementbosque = GetComponent<Caminar_bosque>();
        //_characterController = GetComponent<CharacterController>();
        _characterController = GetComponent<CharacterController>();

        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        _volarhik.enabled = false;
        // _saltarparedes.enabled = true;
        cambiarcaminar = false;
    }

    // Update is called once per frame
    void Update()
    { 
        
    var player_input = GetComponent<PlayerInput>();
       
        //player_input.SwitchCurrentActionMap("Ascensor");
        
        if (_inputHandler._cambio){
            //  Debug.Log("he entradoen el cambio");
            // player_input.SwitchCurrentActionMap("Hikari");
            if (!_inputHandler.movimientoascensor)
            {
                Debug.Log("estoy dentro de movimiento ascensor");
                _volarhik.enabled = false;
                _saltarparedes.enabled = false;
                _volarbosque.enabled = false;
                _scriptseguirhikari.enabled = true;

                _inputHandler._cambio = !_inputHandler._cambio;

            }
            else if (cambiarcaminar)
            {
                _volarbosque.enabled = false;
                _volarhik.enabled = true;
            }
            else
            {
                _volarhik.enabled = false;
                _volarbosque.enabled = true; 
            }
        
        _saltarparedes.enabled = false;
            _movementbosque.enabled = false;
        _scriptseguirhikari.enabled = false;

        }

        else{

            Debug.Log("estoy dentro del else del cambio");
            // player_input.SwitchCurrentActionMap("Raito");

            if (!_inputHandler.movimientoascensor)
            {
                Debug.Log("estoy dentro de movimiento ascensor");
                _volarhik.enabled = false;
                _saltarparedes.enabled = false;
                _volarbosque.enabled = false;
                _scriptseguirhikari.enabled = true;

            }
            else
            {

               
                if (cambiarcaminar)
                {
                    _saltarparedes.enabled = true;
                    _movementbosque.enabled = false;
                }
                else
                {
                    Debug.Log("cambiar");
                    _saltarparedes.enabled = false;
                    _movementbosque.enabled = true;
                }
                _volarhik.enabled = false;
                _volarbosque.enabled = false;
                _scriptseguirhikari.enabled = true;
            }

        }
    }
}
