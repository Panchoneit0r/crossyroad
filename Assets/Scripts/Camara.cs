using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public Player movimiento;
    public float velocidad;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,Vector3.forward * movimiento.carril, velocidad*Time.deltaTime);
    }
}
