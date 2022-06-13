
using UnityEngine;

public class HikariFollow : MonoBehaviour
{
    public Transform target;
    private float z;
    public float smoothSpeed = 0.01f;
    public Vector3 offset;
    public Vector3 offsethor;
    public Vector3 current;
    public float _distance;
    public float altura;
    public float value;
    public float value2;

    CAMBIARHIK cambiarkik;
    void Start()
    {

        z = transform.position.z;
        cambiarkik = GameObject.FindGameObjectWithTag("Player").GetComponent<CAMBIARHIK>();
        altura = 0.8f;
        value = 0.7f;
        value2 = 0;
    }

    void Update()
    {
        // z= -10;

        current = transform.position;

    }

    void LateUpdate()
    {//lo hace despues





        _distance = Vector3.Distance(target.transform.position, transform.position);
        // Debug.Log(_distance);
        if (_distance <= 0.8f)
        {




            // Debug.Log("cerca");
        }



        if (_distance > 0.8f)
        {


            // Debug.Log("lejos");

            Smooth();

        }





        /*
         Vector3 position = transform.position ;
             position.y = (target.position + offset).y;
              position.x = (target.position + offset).x;
             transform.position = position ;
             */
    }



    void Smooth()
    {

        //Debug.Log("MUEVE HOSTIA");

        Vector3 position = (transform.position);
        position.y = target.position.y + altura;

        if (cambiarkik.cambiarcaminar)
        {
            position.x = (target.position + offset).x - value;
            position.z = (target.position + offset).z + value2;
        }
        else { 
            position.x = (target.position + offset).x;
            position.z = (target.position + offset).z - 0.7f;
        }

        float smoothedPositionx = Mathf.Lerp(transform.position.x, position.x, smoothSpeed * Time.deltaTime);
        float smoothedPositionz = Mathf.Lerp(transform.position.z, position.z, smoothSpeed * Time.deltaTime);
        //transform.position = smoothedPosition;
        transform.position = new Vector3(smoothedPositionx, position.y, smoothedPositionz);

        transform.LookAt(target);

    }





}
