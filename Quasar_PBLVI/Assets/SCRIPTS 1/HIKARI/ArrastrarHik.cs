// This script pushes all rigidbodies that the character touches

using UnityEngine;
using System.Collections;

public class ArrastrarHik : MonoBehaviour
{
    public float pushPower = 2.0F;
    public AudioSource _audioarrastrarObjeto;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
         Rigidbody body = hit.collider.attachedRigidbody;

         //Debug.Log("chocandocontraobjeto");

        // no rigidbody
        if (body == null || body.isKinematic)
            return;

        // We dont want to push objects below us
        if (hit.moveDirection.y < -0.3f)
            return;

        // Calculate push direction from move direction,
        // we only push objects to the sides never up and down
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        // If you know how fast your character is trying to move,
        // then you can also multiply the push velocity by that.

        // Apply the push
         if(_audioarrastrarObjeto.isPlaying == false){
         _audioarrastrarObjeto.Play();
         }
        body.velocity = pushDir * pushPower;
    }
}