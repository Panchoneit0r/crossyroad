using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MaxPuntaje : MonoBehaviour
{
    public Text scoreText;
    private void Start()
    {
        // Recuperar el puntaje guardado desde PlayerPrefs.
        int puntajeGuardado = PlayerPrefs.GetInt("PuntajeGuardado");
        ActualizarPuntajeUI(puntajeGuardado);
        
    }
    
    private void ActualizarPuntajeUI(int score)
    {
        // Actualiza el texto en la UI con el puntaje actual.
        if (scoreText != null)
        {
            scoreText.text = "Puntaje: " + score.ToString();
        }
    }
}
