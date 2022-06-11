using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entrarcheckpoint : MonoBehaviour
{
    CHECKPOINT checkpoint;
    public int valorcontador;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<CHECKPOINT>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            checkpoint.contador = valorcontador;
        }
    }
}
