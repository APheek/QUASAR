using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Ascensor : MonoBehaviour
{

    public AudioSource _audioascensor;
    Controller _inputHandler;
    RotoHik2 _roto;
    public Animator _animator;
    private const string ASCENSOR = "Ascensor";
    public bool isPulsedisascensor = false;
    public GameObject jugador;
    public GameObject ascensor;
    public GameObject caja;
    CAMBIARHIK cambiarhik;
    // Start is called before the first frame update
    void Start()
    {
        
        _animator.SetBool(ASCENSOR, isPulsedisascensor);
        _roto = GameObject.FindGameObjectWithTag("Roto2").GetComponent<RotoHik2>();
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        cambiarhik = GameObject.FindGameObjectWithTag("Player").GetComponent<CAMBIARHIK>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_roto._bandera + "del BOTOOOOOOOOOOOOOOOOOOOOON");
    }

    private void OnTriggerStay(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("raito dentro");
            if (_inputHandler._chispa  && _roto._bandera)
            {
                
                Debug.Log("vamos alla");
                _animator.SetBool("Ascensor", true);
                _inputHandler._cambio = !_inputHandler._cambio;
                jugador.gameObject.transform.SetParent(ascensor.gameObject.transform);
                caja.gameObject.transform.SetParent(ascensor.gameObject.transform);
                caja.GetComponent<Rigidbody>().useGravity = false;
                _audioascensor.Play();
                caja.GetComponent<Rigidbody>().isKinematic = true;
               // _volarhik.enabled = false;
                //_scriptseguirhikari.enabled = true;
                _roto._bandera = false;
                _inputHandler.movimientoascensor = false;
            }

        }

    }

}
