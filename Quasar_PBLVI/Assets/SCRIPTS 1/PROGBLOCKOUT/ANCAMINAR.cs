using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANCAMINAR : MonoBehaviour
{
    
       private Animator _animator;
        private const string CAMINAR = "Iswalking";
        public bool isPulsediswalking = false;
       private const string AGACHARSE = "Agacharse";
      public bool isPulsedIsCrouching = false;
      private const string CUCLILLAS = "IsCrouching";
      public bool isPulsedIsCuclillas = false;
       private const string SALTAR = "Jumping";
      public bool isPulsedIsJumping = false;

      private const string SALTARPARED = "WallJump";
      public bool isPulsedIsWallJumping = false;

       private const string DESLIZARSE = "Deslizarse";
      public bool isPulsedIsDeslizar = false;
      
      private const string CHISPAZO = "Chispazo";
      public bool isPulsedIschispazo = false;

    private const string SALTOPARED = "SaltoPared";
    public bool isPulsedIsSaltoPared = false;

    private const string DES = "Des";
    public bool isPulsedIsDES = false;

    private const string TRANSCORRCAM = "TransCorrCam";
    public bool isPulsedIsTransCorrCam = false;

    private const string CORRER = "Isrunning";
    public bool isPulsedIsrunning = false;


    private const string ISONWALL = "isonwall";
    public bool isPulsedisonwall = false;

    private const string WALLJUMPA = "WallJumpA";
    public bool isPulsedisWALJUMPA = false;




    private const string COGER = "Coger";
    public bool isPulsedisCoger = false;





    private const string SOLTAR = "Soltar";
    public bool isPulsedisSoltar = false;


    private const string EMPUJAR = "Empujar";
    public bool isPulsedIsempujar = false;

    private const string EMPCAM = "EmpCam";
    public bool isPulsedIsempujarcam = false;


     private const string ESTCAM = "EstCam";
    public bool isPulsedIsestirarcam = false;


    

    Controller _controller;
    SaltarParedes _movement;
        Arrastrar _arrastrar;
        TriggerNiv4 _scriptchispazo;
    CogerObjeto _cogerobjeto;
    Empujar_atraer _empujaratraer;





    // Start is called before the first frame update
    void Start()
    {
        _empujaratraer = GameObject.FindGameObjectWithTag("HandArrastrar").GetComponent<Empujar_atraer>();
        _cogerobjeto = GameObject.FindGameObjectWithTag("HandCoger").GetComponent<CogerObjeto>();
        _controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>();
        _movement = GameObject.FindGameObjectWithTag("Player").GetComponent<SaltarParedes>();
        _arrastrar = GameObject.FindGameObjectWithTag("Player").GetComponent<Arrastrar>();
         _scriptchispazo = GameObject.FindGameObjectWithTag("TriggerNiv4").GetComponent<TriggerNiv4>();
         _animator = GetComponent<Animator>();
        
        _animator.SetBool(CAMINAR, isPulsediswalking);
         _animator.SetBool(AGACHARSE, isPulsedIsCrouching);
         _animator.SetBool(CUCLILLAS, isPulsedIsCuclillas);
         _animator.SetBool(SALTAR, isPulsedIsJumping);
         _animator.SetBool(SALTARPARED, isPulsedIsWallJumping);
         _animator.SetBool(DESLIZARSE, isPulsedIsDeslizar);
         
         _animator.SetBool(CHISPAZO, isPulsedIschispazo);
        _animator.SetBool(CORRER, isPulsedIsrunning);
        _animator.SetBool(TRANSCORRCAM, isPulsedIsTransCorrCam);

        _animator.SetBool(SALTOPARED, isPulsedIsSaltoPared);
        _animator.SetBool(DES, isPulsedIsDES);

        _animator.SetBool(ISONWALL, isPulsedisonwall);


        _animator.SetBool(WALLJUMPA, isPulsedisWALJUMPA);

        _animator.SetBool(EMPUJAR, isPulsedIsempujar);
        _animator.SetBool(EMPCAM, isPulsedIsempujarcam);
        _animator.SetBool(ESTCAM, isPulsedIsempujarcam);

        _animator.SetBool(COGER, isPulsedisCoger);
        _animator.SetBool(SOLTAR, isPulsedisSoltar);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_arrastrar.EMPUJAR);
        if (_movement.CAMINANDO){

             _animator.SetBool("Iswalking", true);


        }

        else{
            _animator.SetBool("Iswalking", false);
        }

        ///////////////////////TRANSICION CORRER CAMINAR
        if (_movement.TRANSCORRCAM)
        {

            _animator.SetBool("TransCorrCam", true);


        }

        else
        {
            _animator.SetBool("TransCorrCam", false);
        }



        //////////////////////WALL JUMP
        ////////////SALTO SUELO PARED
        if (_movement.SALTOPARED)
        {

            _animator.SetBool("SaltoPared", true);


        }

        else
        {
            _animator.SetBool("SaltoPared", false);
        }


        /////////WALLJUMP
        if (_movement.WALLJUMP)
        {

            _animator.SetBool("WallJump", true);
            _movement.WALLJUMPA = false;
            //_movement.WALLJUMP = false;
        }

        else
        {
            _animator.SetBool("WallJump", false);
        }

        /////////DESLIZARSE


        if (_movement.DESLIZARSE)
        {

            _animator.SetBool("Des", true);


        }

        else
        {
            _animator.SetBool("Des", false);
        }





        /////////WALJUMPA


        if (_movement.WALLJUMPA)
        {

            _animator.SetBool("WallJumpA", true);


        }

        else
        {
            _animator.SetBool("WallJumpA", false);
        }





        //////////////////////IS ON WALL
        if (_movement.isonwall)
        {

            _animator.SetBool("isonwall", true);


        }

        else
        {
            _animator.SetBool("isonwall", false);
        }




        ///////////////CORRER
        if (_movement.CORRER)
        {

            _animator.SetBool("Isrunning", true);


        }

        else
        {
            _animator.SetBool("Isrunning", false);
        }

        //ACACHARSE Y CUCLILLAS

        if (_movement.AGACHARSE)
        {

            _animator.SetBool("Agacharse", true);
        }

        else
        {
            _animator.SetBool("Agacharse", false);
        }


        if (_movement.CUCLILLAS)
        {
            Debug.Log("estoy en cuclillas");

            _animator.SetBool("IsCrouching", true);
        }

        else
        {
            _animator.SetBool("IsCrouching", false);
        }



        //SALTAR

        if (_movement.SALTAR){
            
        _animator.SetBool("Jumping", true);
        }

        else{
           _animator.SetBool("Jumping", false);
        }


        //SALTAR PARED


        if(_movement.WALLJUMP){
            //WALLJUMPA = false;
        _animator.SetBool("WallJump", true);
        }

        else{
           _animator.SetBool("WallJump", false);
        }







        //DESLIZARSE
        //if(_movement.DESLIZARSE){

        //_animator.SetBool("Deslizarse", true);
        //}

        //else{
        //   _animator.SetBool("Deslizarse", false);
        //}






        //EMPUJAR
        if(_empujaratraer.EMPUJAR){

        _animator.SetBool("Empujar", true);
        }

        else{
           _animator.SetBool("Empujar", false);
        }


        if (_movement.EMPCAM)
        {

            _animator.SetBool("EmpCam", true);
        }

        else
        {
            _animator.SetBool("EmpCam", false);
        }


        if (_movement.ESTCAM)
        {

            _animator.SetBool("EstCam", true);
        }

        else
        {
            _animator.SetBool("EstCam", false);
        }



        ///////////////CHISPAZO
        if (_controller.CHISPAZO)
        {

            _animator.SetBool("Chispazo", true);
            _controller._chispa = false;
            _controller.CHISPAZO = false;
        }

        else
        {
            _animator.SetBool("Chispazo", false);
        }





        ///////////////COGER
        if (_cogerobjeto.COGER)
        {

            _animator.SetBool("Coger", true);
            
        }

        else
        {
            _animator.SetBool("Coger", false);
        }


        ///////////////SOLTAR
        if (_cogerobjeto.SOLTAR)
        {

            _animator.SetBool("Soltar", true);
            _cogerobjeto.SOLTAR = false;

        }

        else
        {
            _animator.SetBool("Soltar", false);
        }



    }
}
