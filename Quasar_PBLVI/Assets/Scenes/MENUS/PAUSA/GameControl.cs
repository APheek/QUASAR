using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private bool gameRunning;
    public GameObject gameObjectToDeactivate;
    public GameObject MusicaMenu;
    AudioSource musica_menu;
    public GameObject MusicaJuego;
    AudioSource musica_juego;

    // Start is called before the first frame update
    void Start()
    {
        gameObjectToDeactivate.SetActive(false);
        musica_menu = MusicaMenu.GetComponent<AudioSource>();
        musica_juego = MusicaJuego.GetComponent<AudioSource>();
        musica_menu.Pause();
        musica_juego.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeGameRunningState();
        }
    }


    public void ChangeGameRunningState()
    {
        gameRunning = !gameRunning;

        if (gameRunning)
        {
            //Game Running
            Time.timeScale = 1f;
            gameObjectToDeactivate.SetActive(false);
            //CanvasObject.SetActive(true);
            musica_menu.Pause();
            musica_juego.Play();

        }
        else
        {
            //Game Paused
            Time.timeScale = 0f;
            gameObjectToDeactivate.SetActive(true);
            //CanvasObject.SetActive(false);
            musica_menu.Play();
            musica_juego.Pause();
            
        }
   
    }

    public bool IsGameRunning()
    {
        return gameRunning; 

    }



}
