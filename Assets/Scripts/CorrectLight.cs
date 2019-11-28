using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectLight : MonoBehaviour
{
    public GameObject Light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LightOn()
    {
        Light.active = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
