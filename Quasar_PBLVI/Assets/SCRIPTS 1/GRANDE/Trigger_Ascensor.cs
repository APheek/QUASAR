using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Ascensor : MonoBehaviour
{
    public AudioSource _audioascensor;
    Controller _inputHandler;
    public GameObject jugador;

    public GameObject caja;
    // Start is called before the first frame update
    void Start()
    {
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("raito dentro");
            _inputHandler.movimientoascensor = true; 
            caja.GetComponent<Rigidbody>().isKinematic = false;
            jugador.gameObject.transform.SetParent(null);
            caja.gameObject.transform.SetParent(null);
            caja.GetComponent<Rigidbody>().useGravity = true;
            _audioascensor.Stop();
        }

    }


}
