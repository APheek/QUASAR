using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorCamara : MonoBehaviour
{
    CameraFollow camara;
    public Camera camarish;

    public int contador;
    Controller _inputHandler;
    // Start is called before the first frame update
    void Start()
    {
        camara = camarish.GetComponent<CameraFollow>();


        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(contador == 1 && _inputHandler._cambio)
        {
            camara.enabled = false;
        }
        else if (contador != 0)
        {
            camara.enabled = true;
        }
    }
}
