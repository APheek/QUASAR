using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_puerta_bosque : MonoBehaviour
{
    public Animator _animator;


    private const string PUERTABOSQUE = "Puertabosque";
    public bool isPulsedispuertabosque = false;
    // Start is called before the first frame update
    void Start()
    {
        _animator.SetBool(PUERTABOSQUE, isPulsedispuertabosque);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {


        if (other.gameObject.CompareTag("Objeto"))
        {
            _animator.SetBool("Puertabosque", true);


           



        }

    }

}
