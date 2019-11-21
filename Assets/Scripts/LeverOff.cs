using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverOff : MonoBehaviour
{


    public GameObject[] planets;
    public AudioClip audioClip;

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
            DisableGravity();
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

    private void DisableGravity()
    {
        if (planets == null)
        {

            planets = GameObject.FindGameObjectsWithTag("Planet");
        }

        foreach (GameObject planet in planets)
        {
            planet.GetComponent<ZeroGravityObject>().ToggleFloating(true);
        }
    }
}
