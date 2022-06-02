using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chispa_caja : MonoBehaviour
{
    
        Abrir_caja _tapa;
    Controller _inputHandler;
    RotoHik _roto;
    public HingeJoint _hingeJoint;
    public HingeJoint _hingeJoint2;
    public JointMotor caneHingeMotor;


    // Start is called before the first frame update
    void Start()
    {
        _tapa = GameObject.FindGameObjectWithTag("TapaCajaEle").GetComponent<Abrir_caja>();
        _roto = GameObject.FindGameObjectWithTag("Roto").GetComponent<RotoHik>();
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();

        _hingeJoint.useMotor = true;
        _hingeJoint2.useMotor = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_inputHandler._chispa + "chispa");
        Debug.Log(_tapa.abierto + "abierto");
        Debug.Log(_roto._bandera + "_roto");
    }


    private void OnTriggerStay(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("raito dentro");
            if (_inputHandler._chispa && _tapa.abierto && _roto._bandera)
            {

                

                    Debug.Log("dentro de parar motor");
                    _hingeJoint.useMotor = false;
                    _hingeJoint.useLimits = true;

                _hingeJoint2.useMotor = false;
                _hingeJoint2.useLimits = true;


                _inputHandler._chispa = false;
                   
                

            }
           
        }

    }

}
