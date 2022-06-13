using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoFollowCam : MonoBehaviour
{

    CameraFollow camara;
    public Camera camarish;

    // Start is called before the first frame update
    void Start()
    {
        camara = camarish.GetComponent<CameraFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        StartCoroutine(Waiting());



    }

IEnumerator Waiting() //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
{
    yield return new WaitForSeconds(0.5f);
    camara.enabled = false;

    // transform.localPosition = endpos;



}

}
