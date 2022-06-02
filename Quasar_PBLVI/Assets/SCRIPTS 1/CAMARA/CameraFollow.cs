
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
 public Transform target;
 public Transform targetH;
 private float z;
 public float smoothSpeed = 0.125f; 
 public Vector3 offset;
 Controller _inputHandler;

 void Start(){

 z= transform.position.z;
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
    }

 void Update(){
 // z= -10;
// Debug.Log(_inputHandler._cambio);

 }

 void LateUpdate(){//lo hace despues

  if (_inputHandler._cambio){
     // Debug.Log("estoydentrodecambio");
 Vector3 position = (transform.position);
 position.y = targetH.position.y;
  position.x = targetH.position.x;
  position.z = targetH.position.z;
            Vector3 smoothedPosition = Vector3.Lerp (transform.position, position, smoothSpeed *Time.deltaTime);
 transform.position = position;

 transform.LookAt(targetH);
 /*
  Vector3 position = transform.position ;
      position.y = (target.position + offset).y;
       position.x = (target.position + offset).x;
      transform.position = position ;
      */
  }


  else{
        Vector3 position = (transform.position);
        position.y = (target.position + offset).y;
        position.x = (target.position + offset).x;
        position.z = (target.position + offset).z;
            Vector3 smoothedPosition = Vector3.Lerp (transform.position, position, smoothSpeed *Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(target);

  }




 }
}
