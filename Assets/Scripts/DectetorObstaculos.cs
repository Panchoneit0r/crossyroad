using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DectetorObstaculos : MonoBehaviour
{
    public Player jugador;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstaculo")
        {
            jugador.pasar = false;
        }
        Debug.Log("Entro");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Obstaculo")
        {
            jugador.pasar = true;
        }
    }
}
