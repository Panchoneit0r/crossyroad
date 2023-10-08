using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoore : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private int MaxScore = 0;

    private void Awake()
    {
        // Asegura que este objeto persista entre escenas.
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        
        // Inicializa el puntaje a cero al comenzar el juego.
        score = 0;
        ActualizarPuntajeUI();
        
    }

    public void AumentarPuntaje(int puntos)
    {
        // Incrementa el puntaje y actualiza la UI.
        score += puntos;
        ActualizarPuntajeUI();
    }

    private void ActualizarPuntajeUI()
    {
        // Actualiza el texto en la UI con el puntaje actual.
        if (scoreText != null)
        {
            scoreText.text = "Puntaje: " + score.ToString();
        }
    }

    public void compararPuntaje()
    {
        if (score > MaxScore)
        {
            MaxScore = score;
        }
    }
}
