using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevCarros : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Carro")
        {
            other.transform.Translate(20,0,0);
        }
    
    }
}
