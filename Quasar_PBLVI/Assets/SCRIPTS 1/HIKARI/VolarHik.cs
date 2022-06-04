using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VolarHik : MonoBehaviour
{
    public Transform target;
    //public ControllerHik _playerInput; //Lo pongo tmbn en el NewInputMover
    private CharacterController _charactercontroller;

    public float Speed = 5;
    private Vector2 _input;
    //public Transform FlightArea;
    public Vector3 dir;
    public Vector3 current;
    public Vector2 _flyValue;
    public float yRange = 0.8f;

    public float _distance;
    public Vector3 offset;
    public float smoothSpeed = 10f;
    HikariFollow follow;

    public bool debevolver;

    // Start is called before the first frame update
    void Start()
    {
        _charactercontroller = GetComponent<CharacterController>();
        follow = GetComponent<HikariFollow>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        current = follow.current;
        Move();
        volver();
    }


    private void Update()
    {
        /* if (transform.position.y < yRange)
         {
             transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
         }*/




    }

    private void OnMoverHik(InputValue inputValue)
    {
        // Debug.Log("hikari se mueve");
        _input = inputValue.Get<Vector2>();
        // print(_input);
    }

    private void OnVolarr(InputValue inputValue)
    {
        _flyValue = inputValue.Get<Vector2>();

    }



    void Move()
    {

        Debug.Log("MOOVVEEEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRRRRRRRRRRRRRR");
        float x = _input.x * Speed;
        float z = _input.y * Speed;
        float y = _flyValue.y * Speed;
        // Vector3 dir = Vector3.zero;
        //dir.x = cc.velocity.x*_input.x;


        /*if (_flyValue==0)
        {
            y= 0;
        }
        else
        {
           y= _flyValue;

        }*/
        Vector3 dir = new Vector3(x, y, z) * Time.deltaTime;
        _charactercontroller.Move(dir);
        //dir.z = -cc.velocity.z*_input.y;//el menos es pk esta invertido sino va al reves
        //dir *= Speed * Time.deltaTime;
        //transform.Translate(dir, Space.Self);



    }



    private void volver()
    {
        _distance = Vector3.Distance(target.transform.localPosition, transform.localPosition);


        if (_distance > 18 || debevolver)
        {
            Debug.Log(_distance);
            Debug.Log("distancia");
            debevolver = true;
            _distance = 1.300011f;
            if (debevolver)
            {

                Debug.Log("estoy dentro de volver");
                //debevolver = false;
                Debug.Log("estoy dentro");
                Vector3 position = (transform.position);
                position.y = (target.position + offset).y + 1.3f;
                position.x = (target.position + offset).x;
                position.z = (target.position + offset).z;



                float smoothedPositionx = Mathf.Lerp(transform.position.x, position.x, 5);
                float smoothedPositionz = Mathf.Lerp(transform.position.z, position.z, 5);
                //transform.position = smoothedPosition;
                transform.localPosition = new Vector3(smoothedPositionx, position.y, smoothedPositionz);
                Debug.Log("voy a salir");
            }
        }
        debevolver = false;


    }





}