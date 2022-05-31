using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInicio : MonoBehaviour
{
    public Camera CamaraInicio;
    public Camera CamaraNivel1;
   public Camera CamaraNivel2;
   public Camera CamaraNivel3;
   public Camera CamaraNivel4;
    
    GameObject _botonEntrada1;
    BotonTrigger _botonSalida1;
    GameObject _botonEntrada2;
    BotonTrigger _botonSalida2;
    GameObject _botonEntrada3;
    BotonTrigger _botonSalida3;
    GameObject _botonEntrada4;
    BotonTrigger _botonSalida4;


    public GameObject puntoguardado1;
    public GameObject puntoguardado2;
    public GameObject puntoguardado3;
    public GameObject puntoguardado4;


     public AudioSource _audioWOHOO;
     private bool activaraudio;

    // Start is called before the first frame update
    void Start()
    {
         _botonEntrada1 = GameObject.FindGameObjectWithTag("botonentrada1");
         _botonSalida1 = GameObject.FindGameObjectWithTag("botonsalida1").GetComponent<BotonTrigger>();
         _botonEntrada2 = GameObject.FindGameObjectWithTag("botonentrada2");
         _botonSalida2 = GameObject.FindGameObjectWithTag("botonsalida2").GetComponent<BotonTrigger>();
         _botonEntrada3 = GameObject.FindGameObjectWithTag("botonentrada3");
         _botonSalida3 = GameObject.FindGameObjectWithTag("botonsalida3").GetComponent<BotonTrigger>();
         _botonEntrada4 = GameObject.FindGameObjectWithTag("botonentrada4");
         _botonSalida4 = GameObject.FindGameObjectWithTag("botonsalida4").GetComponent<BotonTrigger>();
        _botonEntrada2.SetActive(false);
        _botonEntrada3.SetActive(false);
        _botonEntrada4.SetActive(false);
        activaraudio = false;


        CamaraInicio.enabled = true;
        CamaraNivel1.enabled = false;
        CamaraNivel2.enabled = false;
        CamaraNivel3.enabled = false;
        CamaraNivel4.enabled = false;


        puntoguardado1.SetActive(false);
        puntoguardado2.SetActive(false);
        puntoguardado3.SetActive(false);
        puntoguardado4.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {
        if (_botonSalida1._botonpulsado){
             
             
            _botonEntrada2.SetActive(true);
             
        }
        if (_botonSalida2._botonpulsado){
             
            _botonEntrada3.SetActive(true);
        }
        if (_botonSalida3._botonpulsado){
            
            _botonEntrada4.SetActive(true);
        }
        if (_botonSalida4._botonpulsado){
             
             
        }
        
    }


    


      private void OnTriggerEnter(Collider other) //el trigger permite que entren en su zona, es como un objeto fantasma. Lo de Collider other, es que alguien ha entrado y el other te dice quien ha entrado
    {

    if(_botonSalida1._celebracion){
        if(_audioWOHOO.isPlaying == false){
         _audioWOHOO.Play();
         _botonSalida1._celebracion=false;
        }
        
    }
          if(_botonSalida2._celebracion){
        if(_audioWOHOO.isPlaying == false){
         _audioWOHOO.Play();
         _botonSalida1._celebracion=false;
        }
        
          }
          if(_botonSalida3._celebracion){
        if(_audioWOHOO.isPlaying == false){
         _audioWOHOO.Play();
         _botonSalida1._celebracion=false;
        }
        
          }
          if(_botonSalida4._celebracion){
        if(_audioWOHOO.isPlaying == false){
         _audioWOHOO.Play();
         _botonSalida1._celebracion=false;
        }
        
          }
        
       
       

    }




}
