using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{

    public AudioClip audioClip;
    public GameObject scoreboard;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "leverTrigger")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = audioClip;
            audio.Play();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "leverTrigger")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = audioClip;
            audio.Stop();
        }
    }
}
