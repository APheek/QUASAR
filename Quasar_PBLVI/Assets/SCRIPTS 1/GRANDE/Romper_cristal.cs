using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Romper_cristal : MonoBehaviour
{
    public GameObject musica;
    public AudioSource _rotocristal;
    public bool explotar;
    public GameObject Destroyed;
    private Vector3 pos = new Vector3(-3.22f, 11.01f, -1.3f);
    private Vector3 rot = new Vector3(-90f, 0f, 0f);
    Controller _inputHandler;
    SaltarParedes saltarparedes;
    // Start is called before the first frame update
    void Start()
    {
        explotar = false;
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        saltarparedes = GameObject.FindGameObjectWithTag("Player").GetComponent<SaltarParedes>();
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
                saltarparedes.enabled = false;
                StartCoroutine(Waiting());


            }

        }

    }


    IEnumerator Waiting() //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
    {

       
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("Cinematica2");
        Destroy(musica);
        yield return null;

    }




}
