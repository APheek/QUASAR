using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chispa_caja : MonoBehaviour
{
    public AudioSource _pararventiladoresconst;
    public AudioSource _pararventiladores;
    
    Controller _inputHandler;
    RotoHik _roto;
    public HingeJoint _hingeJoint;
    public HingeJoint _hingeJoint2;
    public JointMotor caneHingeMotor;
    public GameObject topedeventilador;
    public bool abierto;

    // Start is called before the first frame update
    void Start()
    {
       
        _roto = GameObject.FindGameObjectWithTag("Roto").GetComponent<RotoHik>();
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();

        _hingeJoint.useMotor = true;
        _hingeJoint2.useMotor = true;

       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_inputHandler._chispa + "chispa");
        
        Debug.Log(_roto._bandera + "_roto");
    }


    private void OnTriggerStay(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("raito dentro");
           
                if (_inputHandler._chispa && abierto && _roto._bandera)
                {
                    Debug.Log("Estoy entrando");
                    _pararventiladoresconst.Stop();
                    _pararventiladores.Play();

                    JointLimits limits = _hingeJoint.limits;
                    limits.min = 0;
                    limits.bounciness = 0;
                    limits.bounceMinVelocity = 0;
                    limits.max = 0;
                    _hingeJoint.limits = limits;
                    _hingeJoint2.limits = limits;
                    Debug.Log("dentro de parar motor");
                    _hingeJoint.useLimits = true;
                    _hingeJoint.useMotor = false;

                    _hingeJoint2.useLimits = true;
                    _hingeJoint2.useMotor = false;

                    topedeventilador.SetActive(false);




                
            }
           
        }

    }

}
