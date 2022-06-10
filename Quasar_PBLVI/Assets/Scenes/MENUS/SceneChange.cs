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

    // Start is called before the first frame update
    void Start()
    {
        
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
        //AQUI VA EL CODIGO MARINA
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
