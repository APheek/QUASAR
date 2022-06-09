using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Caminar_bosque : MonoBehaviour
{




    private float desiredRot;
    public float rotSpeed = 250;
    public float damping = 40;

    private bool speedcero;


    private Vector3 targetAngles;
    public float smooth = 0.1f;



    Empujar_atraer _scriptempujar;

    private float alturaoriginal;

    triggerNiv1 _sccripttriggerniv1;
    public bool _agachandose;

    public AudioSource _audiocaminar;
    public AudioSource _audiocorrer;
    public AudioSource _audioagacharse;
    public AudioSource _audiosaltar;
    public AudioSource _audioarrastrar;


    Controller _inputHandler;
    private Vector3 moveVector;
    private Vector3 scale;
    private Vector3 lastMove;
    private bool _groundedPlayer;
    public float speed;
    private float jumpforce = 5f;
    public float gravity = 25;
    private float verticalVelocity;
    private CharacterController controller;
    public LayerMask wallmask;
    public LayerMask groundmask;
    public bool isonwall;

    private int contadorparedes;

    bool isTouchingFront;
    public Transform frontCheck;
    bool wallSliding;
    public float wallSlidingSpeed;
    //ANIMACIONESSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
    public bool CAMINANDO;
    public bool AGACHARSE;
    public bool CUCLILLAS;
    public bool SALTAR;
    public bool ESTCAM;
    public bool CORRER;
    public bool TRANSCORRCAM;


    public bool WALLJUMP;
    public bool WALLJUMPA;
    public bool DESLIZARSE;
    public bool SALTOPARED;

    public bool EMPCAM;





    // Start is called before the first frame update
    void Start()
    {
        ESTCAM = false;
        CAMINANDO = false;
        AGACHARSE = false;
        TRANSCORRCAM = false;
        SALTAR = false;
        WALLJUMP = false;
        WALLJUMPA = false;
        EMPCAM = false;
        _scriptempujar = GameObject.FindGameObjectWithTag("HandArrastrar").GetComponent<Empujar_atraer>();
        _sccripttriggerniv1 = GameObject.FindGameObjectWithTag("trigger").GetComponent<triggerNiv1>();
        controller = GetComponent<CharacterController>();
        _inputHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        isonwall = false;
        _agachandose = false;
        Vector3 scale = (transform.localScale);
        contadorparedes = 0;
        //CORRER = true;
    }


    private void OnEnable()
    {
        //desiredRot = transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log(moveVector + "movee");
        // Debug.Log(_inputHandler.puedegirar);
        if (_scriptempujar.Arrastrando_objeto == true)
        {

            Debug.Log("arrastrandoobjetoon");
            Vector3 forward = transform.forward;
            if (Physics.CheckSphere(transform.position + transform.up * -0.5f, 0.2f, groundmask))
            {

                if (Mathf.Abs(Vector3.Dot(forward, Vector3.forward)) > 0.75f)
                {
                    this.gameObject.transform.position += this.gameObject.transform.forward * Time.deltaTime * (_inputHandler.Vertical * speed);
                    Debug.Log("ws");

                    if ((_inputHandler.Vertical * speed) > 0)
                    {
                        EMPCAM = true;
                        ESTCAM = false;
                        Debug.Log(transform.forward);
                    }
                    else if ((_inputHandler.Vertical * speed) < 0)
                    {
                        EMPCAM = false;
                        ESTCAM = true;
                        Debug.Log(transform.forward);
                    }
                    else
                    {
                        EMPCAM = false;
                        ESTCAM = false;
                    }





                }
                else
                {
                    this.gameObject.transform.position += this.gameObject.transform.forward * Time.deltaTime * (_inputHandler.Horizontal * speed);
                    Debug.Log("ad");


                    if ((_inputHandler.Horizontal * speed) > 0)
                    {
                        EMPCAM = true;
                        ESTCAM = false;
                        Debug.Log(transform.forward);
                    }
                    else if ((_inputHandler.Horizontal * speed) < 0)
                    {
                        EMPCAM = false;
                        ESTCAM = true;
                        Debug.Log(transform.forward);
                    }
                    else
                    {
                        EMPCAM = false;
                        ESTCAM = false;
                    }
                }
            }


            else
            {

                moveVector = Vector3.zero;
                verticalVelocity -= gravity * Time.deltaTime;
                moveVector.y = verticalVelocity;
                controller.Move(moveVector * Time.deltaTime);

                _inputHandler._coger = !_inputHandler._coger;
                EMPCAM = false;
                ESTCAM = false;
                _scriptempujar.EMPUJAR = false;
            }

        }

        else
        {
            SALTAR = _inputHandler._jump;
            // Debug.Log(controller.isGrounded);
            Correr();
            moveVector = Vector3.zero;
            moveVector.x = _inputHandler.Vertical * -speed;
            moveVector.z = _inputHandler.Horizontal * speed;
            if (moveVector.z > 0)
            {
                desiredRot -= rotSpeed * Time.deltaTime;
            }
            else
            {
                desiredRot += rotSpeed * Time.deltaTime;
            }


            if (moveVector.magnitude > 0 && !WALLJUMP)
            {
                transform.LookAt(transform.position + new Vector3(moveVector.x, 0, moveVector.z));

            }



            if (controller.isGrounded)
            {


                isonwall = false;

                //contadorparedes = 0;
                DESLIZARSE = false;
                verticalVelocity = -1;
                _inputHandler.puedegirar = true;

                if (_inputHandler._jump)
                {
                    _audiosaltar.Play();
                    verticalVelocity = jumpforce;
                    _inputHandler._jump = false;
                    TRANSCORRCAM = true;

                }


            }

            else
            {
                CAMINANDO = false;

                if (isonwall)
                {
                    verticalVelocity -= gravity * Time.deltaTime * 0.81f;


                    DESLIZARSE = true;

                    if (_audioarrastrar.isPlaying == false)
                    {
                        _audioarrastrar.Play();
                    }

                }

                else
                {
                    verticalVelocity -= gravity * Time.deltaTime;
                    DESLIZARSE = false;
                    _audioarrastrar.Stop();
                }

                moveVector = lastMove;
            }

            moveVector.y = 0;
            moveVector.Normalize();
            moveVector *= speed;
            moveVector.y = verticalVelocity;

            controller.Move(moveVector * Time.deltaTime);
            lastMove = moveVector;



            if (controller.isGrounded && (controller.velocity.x != 0 || controller.velocity.z != 0))
            {

                TRANSCORRCAM = true;
                if (speed == 1)
                {
                    CAMINANDO = true;
                    CORRER = false;

                    if (_audiocaminar.isPlaying == false)
                    {
                        if (speed == 1)
                        {

                            _audiocaminar.Play();



                        }
                    }
                }
                else if (speed == 3.5)
                {
                    CAMINANDO = false;
                    CORRER = true;
                }

            }


            else
            {
                CAMINANDO = false;
                CORRER = false;

                //CORRER = false;
                _audiocaminar.Stop();
                TRANSCORRCAM = false;
            }
        }

    }

    void FixedUpdate()
    {
        if (Physics.CheckSphere(transform.position + transform.forward * 0.26f, 0.2f, wallmask))
        {
            isonwall = true;
        }
        else
        {
            isonwall = false;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //gravity = 10;

        if (!controller.isGrounded && hit.normal.y < 0.1f)
        {

            wallSliding = true;

            if (_inputHandler._jump)
            {


                WALLJUMP = true;
                WALLJUMPA = true;


                CAMINANDO = false;
                Debug.DrawRay(hit.point, hit.normal, Color.red, 1.25f);
                verticalVelocity = jumpforce;


                moveVector = (hit.normal);
                Debug.Log((hit.normal * 5000f));

                // Debug.Log(hit.normal + "hit normal");
                _inputHandler._jump = false;
                speedcero = true;

                // Debug.Log("giro");

                transform.rotation = Quaternion.LookRotation(hit.normal);

            }

            else
            {


                wallSliding = false;
                CAMINANDO = false;
                WALLJUMP = false;
                WALLJUMPA = false;


                //  CORRER = false;

            }
            // _inputHandler.puedegirar = false;
        }
        else
        {
            wallSliding = false;
            CAMINANDO = false;
            WALLJUMP = false;
            WALLJUMPA = false;
            //  CORRER = false;

        }
    }




    private void Correr()
    {



        if (_inputHandler._run || _inputHandler._agacharse || _sccripttriggerniv1._banderatriggerNiv1 || WALLJUMP)
        {
            if (_inputHandler._run)
            {
                speed = 3.5f;
            }

            else if (WALLJUMP)

            {
                jumpforce = 7f;
                speed = 5f;
            }




            else if (_inputHandler._agacharse)
            {

                alturaoriginal = controller.height;
                controller.height = Mathf.Lerp(alturaoriginal, 1.15f, 0.01f);
                Vector3 originalcenter = controller.center;
                Vector3 newcenter = new Vector3(0, -0.5f, 0);
                controller.center = Vector3.Lerp(originalcenter, newcenter, 0.01f);


                if (controller.velocity.x != 0 || controller.velocity.z != 0)
                {
                    AGACHARSE = true;
                    speed = 1;
                    _agachandose = true;
                    CUCLILLAS = true;

                }
                else
                {
                    CUCLILLAS = false;
                    AGACHARSE = true;

                }



            }

            else if (_agachandose && _sccripttriggerniv1._banderatriggerNiv1)
            {
                controller.height = 1.15f;

                alturaoriginal = controller.height;
                // controller.height = Mathf.Lerp(alturaoriginal, 1, 0.001f);

                controller.center = new Vector3(0, -0.5f, 0);
                // _inputHandler._run = false;
                if (controller.velocity.x != 0 || controller.velocity.z != 0)
                {
                    AGACHARSE = true;
                    speed = 1;
                    _agachandose = true;
                    CUCLILLAS = true;
                }
                else
                {
                    CUCLILLAS = false;
                    AGACHARSE = true;
                }


            }
            // _inputHandler._run=false;
        }

        else
        {
            controller.height = 1.53f;
            // controller.height = Mathf.Lerp(alturaoriginal, 1, 10f);
            controller.center = new Vector3(0, -0.25f, 0);
            // AGACHARSE = false;

            AGACHARSE = false;
            CUCLILLAS = false;
            _agachandose = false;


            //if (WALLJUMP)
            //{

            //}
            // else
            // {
            speed = 1f;

            // }



            // transform.localScale = new Vector3(0.35638f, 0.35638f, 0.35638f);
        }



    }








    /* if(controller.velocity.x!=0 || controller.velocity.z!=0){
           AGACHARSE = true;
         if (_audioagacharse.isPlaying == false){
             if (speed==1){

     _audioagacharse.Play();
    // AGACHARSE = true;

             }
         }
     }
     else{
        _audioagacharse.Stop();
        AGACHARSE = false;

     }*/








}
