using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_lav1 : MonoBehaviour
{
    public Camera Camaradesactivar;
    public Camera CamaraActivar;
    public Transform _checkpoint;
    public Transform _player;
    Controller _inputHandler;
   
    public Animator _animator;
    public Animator _animator2;
    private const string PUERTABOSQUE = "Puertabosque";
    public bool isPulsedispuertabosque = false;
    public AudioSource _ambientebosque;

    private const string CANVA = "canva_a_negro";
    public bool isPulsediscanva = false;

    CAMBIARHIK cambiarkik;
    SaltarParedes _saltarparedes;
    Caminar_bosque _movementbosque;

    // Start is called before the first frame update
    void Start()
    {
        _animator.SetBool(PUERTABOSQUE, isPulsedispuertabosque);
        _animator2.SetBool(CANVA, isPulsediscanva);
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        _saltarparedes =GameObject.FindGameObjectWithTag("Player").GetComponent<SaltarParedes>();
        _movementbosque = GameObject.FindGameObjectWithTag("Player").GetComponent<Caminar_bosque>();
        cambiarkik = GameObject.FindGameObjectWithTag("Player").GetComponent<CAMBIARHIK>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            _animator.SetBool("Puertabosque", false);

            _ambientebosque.Stop();
            StartCoroutine(Waiting());
           


        }

    }



    IEnumerator Waiting() //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
    {
        yield return new WaitForSeconds(0.3f);
        _animator2.SetBool("canva_a_negro", true);
        yield return new WaitForSeconds(0.5f);
        _player.transform.position = _checkpoint.transform.position;
       // _player.transform.rotation = _checkpoint.transform.rotation;
          
       CamaraActivar.enabled = true;
        Camaradesactivar.enabled = false;
        cambiarkik.cambiarcaminar = true;
        _movementbosque.enabled = false;

        yield return null;

        // transform.localPosition = endpos;



    }
}
