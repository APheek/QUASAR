using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Romper_cristal : MonoBehaviour
{
    public AudioSource _rotocristal;
    public bool explotar;
    public GameObject Destroyed;
    private Vector3 pos = new Vector3(-3.22f, 11.01f, -1.3f);
    private Vector3 rot = new Vector3(-90f, 0f, 0f);
    Controller _inputHandler;
    // Start is called before the first frame update
    void Start()
    {
        explotar = false;
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
            Debug.Log("raito dentro");
            if (_inputHandler._chispa && explotar)
            {

                Instantiate(Destroyed, transform.position, transform.rotation);
                Destroy(gameObject);
                _rotocristal.Play();


            }

        }

    }




}
