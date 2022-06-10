using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Wall : MonoBehaviour
{
    public GameObject destruir;
    public GameObject volver;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {

            StartCoroutine(Waiting());
           



        }

    }



    IEnumerator Waiting() //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
    {
        yield return new WaitForSeconds(0.5f);
        destruir.SetActive(false);

        if (volver != null)
        {
            volver.SetActive(true);
        }
        yield return null;

    }
}
