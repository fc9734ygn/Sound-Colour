using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    public float startBoundary;
    public float endBoundary;
    public float movementSpeed;
    private bool isActive;
    public AudioClip activationSound;
    public AudioClip hitSound;
    public int healthPoints;
    public GameObject body;
    public GameObject explosionPrefab;
    public GameObject rewardBall;

    private Vector3 positionStart;
    private Vector3 positionEnd;

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
        body.SetActive(true);
        PlayAudioClip(activationSound);
    }

    private void PlayAudioClip(AudioClip clip)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = clip;
        audio.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Snowball")
        {
            ReceiveDamage();
        }
    }

    private void ReceiveDamage()
    {
        PlayAudioClip(hitSound);

        healthPoints--;
        if (healthPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        explosion.SetActive(true);
        rewardBall.SetActive(true);
        Destroy(gameObject);
    }
}
