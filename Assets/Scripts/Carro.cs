using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update

    private Player player;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            player = other.GetComponent<Player>();
            player.Muerte();
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidad* Time.deltaTime,0, 0);
    }
}
