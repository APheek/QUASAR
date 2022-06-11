using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class SceneChange : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject menuSalir;
    public GameObject menuOpciones;
    public GameObject menuControles;
    public GameObject menuReiniciar;


    public Transform checkpoint0;
    public Transform checkpoint1;
    public Transform checkpoint2;
    public Transform checkpoint3;
    public Transform checkpoint4;
    public Transform _player;

    CHECKPOINT checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<CHECKPOINT>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ChangeScene()
    {
        SceneManager.LoadScene("Cinematica");
    }


    public void ChangeSceneInicio()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    public void ChangeSceneControlesPause()
    {
        SceneManager.LoadScene("Controles");
    }

    public void ChangeSceneOpciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void ChangeSceneOpcionesPause()
    {
        SceneManager.LoadScene("Opciones - pause");
    }

    public void ChangeSceneReiniciarNivel()
    {
        SceneManager.LoadScene("ReiniciarNivel");
    }

    public void ChangeSceneSalir()
    {
        SceneManager.LoadScene("SalirSeguro");
    }

    public void ChangeSceneSalirPause()
    {
        SceneManager.LoadScene("SalirMenu");
    }


    public void ChangeScenePause()
    {
        SceneManager.LoadScene("Pause");
    }


    public void VolverJuego()
    {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(false);
        menuControles.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuieroOpciones()
    {
        menuOpciones.SetActive(true);
    }

    public void QuieroControles()
    {
        menuControles.SetActive(true);
    }

    public void QuieroSalir()
    {
        menuSalir.SetActive(true);
    }

    public void QuieroReiniciar()
    {
        menuReiniciar.SetActive(true);
    }

    public void VolverMenuPausa()
    {
        menuSalir.SetActive(false);
        menuOpciones.SetActive(false);
        menuControles.SetActive(false);
        menuReiniciar.SetActive(false);
    }

    public void ReinicioCheckpoint()
    {
        if (checkpoint.contador==0)
        {
            _player.transform.position = checkpoint0.transform.position;
        }
        else if (checkpoint.contador == 1)
        {
            _player.transform.position = checkpoint1.transform.position;

        }
        else if (checkpoint.contador == 2)
        {
            _player.transform.position = checkpoint2.transform.position;

        }
        else if (checkpoint.contador == 3)
        {
            _player.transform.position = checkpoint3.transform.position;
        }
        else
        {
            _player.transform.position = checkpoint4.transform.position;

        }

        menuPausa.SetActive(false);
        menuOpciones.SetActive(false);
        menuControles.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
