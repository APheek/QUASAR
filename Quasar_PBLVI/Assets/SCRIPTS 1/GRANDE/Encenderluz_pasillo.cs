using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encenderluz_pasillo : MonoBehaviour
{

    public AudioSource _luces;
    public Animator _animator;
    //private const string CANVAPASILLO2 = "canva_pasillo2";
    //public bool isPulsediscanvapasillo2 = false;
    // Start is called before the first frame update
    void Start()
    {
        //_animator.SetBool(CANVAPASILLO2, isPulsediscanvapasillo2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {



            _animator.SetBool("luz pasillo", true);

            _luces.Play();

        }

    }
}
