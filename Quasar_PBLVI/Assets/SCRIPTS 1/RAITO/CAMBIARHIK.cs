using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CAMBIARHIK : MonoBehaviour
{
    CharacterController _characterController;
    Controller _inputHandler;
    VolarHik _volarhik;
   SaltarParedes _saltarparedes;
   HikariFollow _scriptseguirhikari;

    // Start is called before the first frame update
    void Start()
    {
        _scriptseguirhikari = GameObject.FindGameObjectWithTag("hikari").GetComponent<HikariFollow>();
       _volarhik = GameObject.FindGameObjectWithTag("hikari").GetComponent<VolarHik>();
    _saltarparedes = GetComponent<SaltarParedes>();
        //_characterController = GetComponent<CharacterController>();
         _characterController = GetComponent<CharacterController>();

        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        _volarhik.enabled = false;
          _saltarparedes.enabled = true;
    }

    // Update is called once per frame
    void Update()
    { 
        
    var player_input = GetComponent<PlayerInput>();
       
        //player_input.SwitchCurrentActionMap("Ascensor");
        
        if (_inputHandler._cambio){
         //  Debug.Log("he entradoen el cambio");
       // player_input.SwitchCurrentActionMap("Hikari");
        _volarhik.enabled = true;
        _saltarparedes.enabled = false;
        _scriptseguirhikari.enabled = false;

        }

        else{
          // player_input.SwitchCurrentActionMap("Raito");
           _volarhik.enabled = false;
           _saltarparedes.enabled = true;
         //  _scriptseguirhikari.enabled = true;

        }
    }
}
