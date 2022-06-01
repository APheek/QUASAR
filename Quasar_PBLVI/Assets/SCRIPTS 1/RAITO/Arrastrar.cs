// This script pushes all rigidbodies that the character touches

using UnityEngine;
using System.Collections;

public class Arrastrar : MonoBehaviour
{
    public AudioSource _audioarrastrarObjeto;
    public float pushPower = 2.0F;



    public bool EMPUJAR;

    [SerializeField]
    private float forceMagnitude;

    void Start(){
        EMPUJAR=false;
    }


    void Update(){
        //EMPUJAR =false;

    }


    private void OnTriggerEnter(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {
        //if (_coger) {
            //Si entra alguien que no tiene un jumper, jumper será nulo. 
            //var opendoor = other.GetComponent<opendoor>();
            if (other.gameObject.tag == "Player") //Esto nos hace saber si el other que ha entrado tiene o no un jumper añadido.
            {
                /*
                // if (other.gameObject.tag == "Player")


                Rigidbody body = hit.collider.attachedRigidbody;

                //Debug.Log("chocandocontraobjeto");

                // no rigidbody
                if (body == null || body.isKinematic)
                {
                    // EMPUJAR =false;
                    //  EMPUJAR= false;
                    //_audioarrastrarObjeto.Stop();
                    return;
                }

                // We dont want to push objects below us
                if (hit.moveDirection.y < -0.3f)
                {
                    //EMPUJAR =false;
                    //_audioarrastrarObjeto.Stop();
                    return;
                }


                // Calculate push direction from move direction,
                // we only push objects to the sides never up and down
                Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
                // EMPUJAR = true;
                // If you know how fast your character is trying to move,
                // then you can also multiply the push velocity by that.
                if (_audioarrastrarObjeto.isPlaying == false)
                {
                    _audioarrastrarObjeto.Play();
                }
                // Apply the push
                body.velocity = pushDir * pushPower;*/
           // }

            }
    }


   


    /*


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;

        if(rigidbody != null){
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();


            rigidbody.AddForceAtPosition(forceDirection * forceMagnitude, transform.position, ForceMode.Impulse);

        }

    }*/

}