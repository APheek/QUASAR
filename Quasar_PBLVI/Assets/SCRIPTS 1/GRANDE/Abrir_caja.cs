using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir_caja : MonoBehaviour
{
    public AudioSource _abrircaja;

    private Rigidbody _rigidbody;
    private HingeJoint _hingeJoint;

    public JointMotor caneHingeMotor;
    public bool abierto;
    private bool bandera;
    private int contador;


    // Start is called before the first frame update
    void Start()
    {

        abierto = false;
        contador = 0;

        _hingeJoint = GetComponent<HingeJoint>();
        caneHingeMotor = _hingeJoint.motor;

        

        _rigidbody = GetComponent<Rigidbody>();

        _hingeJoint.useMotor = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
  

        private void OnTriggerStay(Collider other)
    {

        
        if (other.gameObject.CompareTag("Objeto"))
        {
           
                _abrircaja.Play();
                bandera = true;
                _hingeJoint.useMotor = true;
                abierto = true;
            
        }

    }

}
