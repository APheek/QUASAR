using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberia_torcerse : MonoBehaviour
{

    private Animator _animator;
    private const string GIRAR = "Tub_gir";
    public bool isPulsedisrotate= false;

    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool(GIRAR, isPulsedisrotate);

    }

    // Update is called once per frame
    void Update()
    {
        

    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("arrastrar"))
        {
            _animator.SetBool("Tub_gir", true);
        }
    }





    


}
