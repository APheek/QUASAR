

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour

   
{

    SaltarParedes saltarparedes;


    public bool movimientoascensor;



    public bool puedegirar;

     private CharacterController _characterController;
    public float Horizontal => _movementc.x;
    public float Vertical => _movementc.y;  

     public float Arriba => _subircuerda.y;
    public float BHorizontal => _balanceo.x;
    public float BVertical => _balanceo.y; 
    
    
    //public float PlayerVelocity => _playerVelocity
    
    //public bool 
    // public float Arriba => _movementv.y;
   // public bool Jump => _jump;
    //private bool _jump;
   
    public bool _run;
     public bool _jump;
     public bool _coger;
     public bool _balancearse;
     public bool _cambio;
     public bool _boton;
     public bool _puedopulsarlo;
    public bool _puedocoger;

public bool _agacharse;
public bool _chispa;



public bool _pared;


    private Vector2 _movementc;
    private Vector2 _balanceo;
     private Vector2 _subircuerda;
    //private Vector2 _movementv;




    /// ANIMACIONES
    public bool CHISPAZO;


    // Start is called before the first frame update
    void Start()
    {
        movimientoascensor = false;
        saltarparedes = GameObject.FindGameObjectWithTag("Player").GetComponent<SaltarParedes>();

        _characterController = GetComponent <CharacterController>();
        _run = false;
       _coger = false;
       _cambio = false;
       _boton = false;
       _puedopulsarlo = false;
        puedegirar = true;

    }

    // Update is called once per frame
    void Update()
    {

    //Debug.Log(_scriptbotones._puedepulsarboton);
        //Debug.Log("coger en update");
       // Debug.Log(_coger);
    }


    void OnCaminar(InputValue inputValueh)
    {

        //Debug.Log("MOVER");

        if (puedegirar)
        {
            _movementc = inputValueh.Get<Vector2>();
        }
    }
    private void OnCAMBIARHIKARI ()
    {
       

        _cambio= !_cambio;
      //  Debug.Log(_cambio);
    }

     private void OnCambioRaito ()
    {
        _cambio= !_cambio;
       // Debug.Log(_cambio);
    }

     private void OnCHISPA ()
    {
       
        _chispa=true;
        //Debug.Log(_chispa);
        CHISPAZO = true;
    }

    private void OnCorrer ()
    {

        if (_agacharse==true || saltarparedes.AGACHARSE==true)
        {
            _run = false;
        }
        else
        {
            _run = true;
        }
        
       // Debug.Log(_run);
    }


     private void OnBoton ()
    {
          if(_puedopulsarlo){
            _boton = true;
          }
    }



    private void OnNocorrer(){
         
        _run = false;
       // Debug.Log(_run);
    } 


    private void OnJump(){
        if (_agacharse == true || saltarparedes.AGACHARSE == true)
        {
            _jump = false;
        }
        else
        {
            _jump = true;
        }
        


   // }
    
   // else{
     // _jump = false;  
   //}
    }


     private void OnAgacharse ()
    {
       // Debug.Log("Saltar");

        _agacharse = true;
    }

    private void OnNoagacharse(){
        _agacharse = false;
    } 



    private void OnCoger(){
        if (_puedocoger)
        {
            _coger = !_coger;
        }
    }


    private void OnNocoger(){
        Debug.Log("soltar cogiendo");
        _coger = false;

    }

    private void OnPAREDES(){
        _pared = true;
    }


    void OnCuerda(InputValue inputValueb){
         _balanceo = inputValueb.Get<Vector2>();

    }


    private void OnBalanceo(){

       // Debug.Log("Cogiendo");
        _balancearse = true;
        //Debug.Log(_coger);
    }


    private void OnSoltarbalanceo(){
        _balancearse = false;

    }


   private void OnSubircuerda(InputValue value)
    {

    var val = value.Get<Vector2>();
    _subircuerda = val;
    }
}


