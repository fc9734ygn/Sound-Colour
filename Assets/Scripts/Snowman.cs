using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    public float startBoundary;
    public float endBoundary;
    public float movementSpeed;
    public bool isActive;
    public AudioClip activationSound;

    private Vector3 positionStart;
    private Vector3 positionEnd;


    // Start is called before the first frame update
    void Start()
    {
        Activate();
        positionStart = transform.position + new Vector3(0, 0, -startBoundary);
        positionEnd = transform.position + new Vector3(0, 0, endBoundary);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            MoveAround();
        }
    }

    private void MoveAround()
    {
        transform.position = Vector3.Lerp(positionStart, positionEnd, Mathf.PingPong(Time.time * movementSpeed, 1.0f));
    }

    public void Activate()
    {
        isActive = true;
        PlayActivationAudio();
    }

    private void PlayActivationAudio()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
