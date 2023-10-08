using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public GameObject panatallaPause;
    public GameObject botones;

    private void Start()
    {
        panatallaPause.SetActive(false);
    }

    public void pause()
    {
        Time.timeScale = 0; // Detener el tiempo
        panatallaPause.SetActive(true);
        botones.SetActive(false);
    }
    public void play()
    {
        Time.timeScale = 1; // Detener el tiempo
        panatallaPause.SetActive(false);
        botones.SetActive(true);
    }
    public void CambiarEscena(string nombreDeEscena)
    {
        SceneManager.LoadScene(nombreDeEscena);
    }
    public void activatepause()
    {
        
    }
    
    public void CerrarLaAplicacion()
    {
        // Aplicar lógica adicional si es necesario antes de cerrar el juego.
        // Por ejemplo, guardar progreso del juego, realizar limpieza, etc.

        // Llamar a Application.Quit() para cerrar la aplicación.
        Application.Quit();
    }
    
}
