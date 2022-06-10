using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecamera : MonoBehaviour
{
    CameraFollow camara;
     public Camera camarish;
    [SerializeField]
    private float y;
    [SerializeField]
    private float x;
    [SerializeField]
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        camara= camarish.GetComponent<CameraFollow>();
        //camara = GameObject.GetComponent<CameraFollow>();
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

        Debug.Log("camarish");
        Vector3 position = Vector3.zero;
        position.y = y;
        position.x = x;
        position.z = z;

        float duration = 4;

        for (float t = 0; t < duration; t += Time.deltaTime)
        {

            Vector3 smoothedPosition = Vector3.Lerp(camara.offset, position, 1f * Time.deltaTime);
            camara.offset = smoothedPosition;
            yield return null;

        }
        yield return null;

    }

}
