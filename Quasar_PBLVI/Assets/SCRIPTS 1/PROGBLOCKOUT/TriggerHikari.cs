using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHikari : MonoBehaviour
{
    public AudioSource _Hikariaudio;
    private bool activaraudio;
    // Start is called before the first frame update
    void Start()
    {
        activaraudio = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     private void OnTriggerEnter(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        //Si entra alguien que no tiene un jumper, jumper será nulo. 
        //var opendoor = other.GetComponent<opendoor>();
        if (other.gameObject.tag == "Player") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
        {
            if(_Hikariaudio.isPlaying == false && (activaraudio==true)){
         _Hikariaudio.Play();
        activaraudio = false;
       
        }

    }
    }



}
