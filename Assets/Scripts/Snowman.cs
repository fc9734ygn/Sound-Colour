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

    public int healthPoints;


    void Start()
    {
   
        positionStart = transform.position + new Vector3(0, 0, -startBoundary);
        positionEnd = transform.position + new Vector3(0, 0, endBoundary);
    }

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
        MakeVisible();
        PlayActivationAudio();
    }

    private void PlayActivationAudio()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Snowball")
        {
            healthPoints--;
        }
    }

    private void MakeVisible()
    {
        foreach (Renderer r in this.gameObject.GetComponentsInChildren(typeof(Renderer)))
        {
            r.enabled = true;
        }
    }
}
