using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiar_hikari : MonoBehaviour
{
    
    public GameObject Hikari;
    
   // private float y;
    HikariFollow hikari;
    public float inicial;

    // Start is called before the first frame update
    void Start()
    {
        hikari = GameObject.FindGameObjectWithTag("hikari").GetComponent<HikariFollow>();
        //camara = GameObject.GetComponent<CameraFollow>();
        //inicial = hikari.altura;
    }

    // Update is called once per frame
    void Update()
    {
        //    Debug.Log(inicial + "esta es la que esta en script");
        //    Debug.Log(hikari.altura + "esta es la que hay en el otro script");
        //}
    }



    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
           // hikari.altura = Mathf.Lerp(hikari.altura, inicial, 1f * Time.deltaTime);
            hikari.altura = inicial;



        }

    }

    IEnumerator Waiting() //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
    {

        Debug.Log("camarish");
        



        float duration = 4;

        for (float t = 0; t < duration; t += Time.deltaTime)
        {

           
            yield return null;

            

        }
        yield return null;

    }

}
