using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectLight : MonoBehaviour
{
    public GameObject Light;
    public GameObject Gas;
    public AudioClip Correct;
    AudioSource GasLeak;

    // Start is called before the first frame update
    void Start()
    {
        GasLeak = GetComponent<AudioSource>();

        GasLeak.Play();
    }




    public void LightOn()
    {
        Light.active = true;
        Gas.active = false;
        AudioSource.PlayClipAtPoint(Correct, transform.position);
        GasLeak.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
