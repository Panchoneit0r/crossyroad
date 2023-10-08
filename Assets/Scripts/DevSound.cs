using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevSound : MonoBehaviour
{
    public AudioSource miAudioSource; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            miAudioSource.Play(); 
        }
    }
}
