using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir_caja : MonoBehaviour
{
    public AudioSource _abrircaja;

    private Rigidbody _rigidbody;
    public HingeJoint _hingeJoint;

    public JointMotor caneHingeMotor;
    public bool abierto;
    private bool bandera;
    private int contador;
    Controller _inputHandler;
    Chispa_caja _tapa;

    // Start is called before the first frame update
    void Start()
    {

        abierto = false;
        contador = 0;

        _tapa = GameObject.FindGameObjectWithTag("TapaCajaEle").GetComponent<Chispa_caja>();
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        caneHingeMotor = _hingeJoint.motor;

        

        _rigidbody = GetComponent<Rigidbody>();

        _hingeJoint.useMotor = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(contador == 1)
        {
            
            Destroy(gameObject);
            
        }
    }
  

        private void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.CompareTag("Objeto"))
        {
            if (_inputHandler._coger)
            {
                _tapa.abierto = true;
                _abrircaja.Play();
                bandera = true;
                _hingeJoint.useMotor = true;

                contador += 1;
            }
        }

    }

}
