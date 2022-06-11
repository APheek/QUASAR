using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger1_pasillo2 : MonoBehaviour
{

    public AudioSource _luces;


    public Animator _animator;
    public Animator _animator2;
    private const string CANVAPASILLO2 = "canva_pasillo2";
    public bool isPulsediscanvapasillo2 = false;

    private const string LUZPASILLO1 = "luz pasillo";
    public bool isPulsedisLUZ = false;

    // Start is called before the first frame update
    void Start()
    {
        _animator.SetBool(CANVAPASILLO2, isPulsediscanvapasillo2);
        _animator2.SetBool(LUZPASILLO1, isPulsedisLUZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            


            StartCoroutine(Waiting());



        }

    }


    IEnumerator Waiting() //Como todos los codigos tendrian lo mismo, hacemos una funcion para todas. 
    {
        yield return new WaitForSeconds(4f);
        _animator.SetBool("canva_pasillo2", true);
        _animator2.SetBool("luz pasillo", true);
        _luces.Play();
        yield return null;

        // transform.localPosition = endpos;



    }

}
