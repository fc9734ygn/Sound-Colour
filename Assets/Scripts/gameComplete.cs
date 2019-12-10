using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameComplete : MonoBehaviour
{
    public GameObject light0;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;

    void Update()
    {
        if (light0.active && light1.active && light2.active && light3.active)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
