using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mundo : MonoBehaviour
{
    public int carril = 0;
    public GameObject[] pisos;
    public int pisocreado;

    private void Start()
    {
        for (int i = 0; i < pisocreado; i++)
        {
             CrearPiso();
        }
    }

    public void CrearPiso()
    {
        Instantiate(pisos[Random.Range(0, pisos.Length)], Vector3.forward * carril, Quaternion.identity);
        carril++;
    }
}
