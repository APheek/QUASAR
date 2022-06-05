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


    private const string CANVA = "canva_a_negro";
    public bool isPulsediscanva = false;

    // Start is called before the first frame update
    void Start()
    {
        _animator.SetBool(PUERTABOSQUE, isPulsedispuertabosque);
        _animator2.SetBool(CANVA, isPulsediscanva);
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
            _animator.SetBool("Puertabosque", false);


            StartCoroutine(Waiting());
           


        }

    }



    IEnumerator Waiting() //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
    {
        yield return new WaitForSeconds(1f);
        _animator2.SetBool("canva_a_negro", true);
        yield return new WaitForSeconds(2f);
        _player.transform.position = _checkpoint.transform.position;
        _player.transform.rotation = _checkpoint.transform.rotation;
        

        yield return new WaitForSeconds(1f);
        CamaraActivar.enabled = true;
        Camaradesactivar.enabled = false;
        
        yield return null;

        // transform.localPosition = endpos;



    }
}