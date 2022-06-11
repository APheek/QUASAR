using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_puerta_bosque : MonoBehaviour
{
    public Animator _animator;
    Controller _inputHandler;
    public AudioSource _abrirpuerta;
    private const string PUERTABOSQUE = "Puertabosque";
    public bool isPulsedispuertabosque = false;
    // Start is called before the first frame update
    void Start()
    {
        _animator.SetBool(PUERTABOSQUE, isPulsedispuertabosque);
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
            if (_inputHandler._coger)
            {
                _animator.SetBool("Puertabosque", true);

                if (_abrirpuerta.isPlaying == false)
                {
                    _abrirpuerta.Play();
                }
            }

            
        }

    }

}
