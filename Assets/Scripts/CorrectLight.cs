using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class CorrectLight : MonoBehaviour
{
    public GameObject Light;
    public GameObject Gas;
    public AudioClip Correct;
    AudioSource GasLeak;
    VRTK_PolicyList policyList;
    public AudioClip incorrectSound;


    // Start is called before the first frame update
    void Start()
    {
        policyList = GetComponent<VRTK_PolicyList>();
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
