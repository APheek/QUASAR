using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberia_torcerse : MonoBehaviour
{

    private Animator _animator;
    private const string GIRAR = "Tub_gir";
    public bool isPulsedisrotate= false;
    Romper_cristal explote;
    

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool(GIRAR, isPulsedisrotate);
        explote = GameObject.FindGameObjectWithTag("Romper_cristal").GetComponent<Romper_cristal>();

    }

    // Update is called once per frame
    void Update()
    {
        

    }



    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("arrastrar"))
        {
            _animator.SetBool("Tub_gir", true);
            explote.explotar = true;
        }
    }





    


}
