using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverOn : MonoBehaviour
{

    public AudioClip audioClip;
    public GameObject scoreboard;
    public GameObject[] planets;

    private void Start()
    {
        planets = GameObject.FindGameObjectsWithTag("Planet");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "leverTrigger")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = audioClip;
            audio.Play();
            EnableGravity();
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

    private void EnableGravity()
    {

        if (planets == null)
        {
            planets = GameObject.FindGameObjectsWithTag("Planet");
        }
      
        foreach (GameObject planet in planets)
        {
            planet.GetComponent<ZeroGravityObject>().ToggleFloating(false);
        }
    }
}
