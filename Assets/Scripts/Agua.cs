using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
    private Player player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            player = other.GetComponent<Player>();
            StartCoroutine(player.Ahogarse());
        }
    }
}
