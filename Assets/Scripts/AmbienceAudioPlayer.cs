using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceAudioPlayer : MonoBehaviour
{
    public AudioClip mainClip;
    public AudioClip jungleClip;
    public AudioClip arcticClip;
    public AudioClip coastalClip;
    public AudioClip spaceClip;

    public Material JungleSkybox;
    public Material SpaceSkybox;
    public Material ArcticSkybox;
    public Material CoastalSkybox;

    private bool hasMainIntroBeenPlayed = false;

    private void PlayNarationAudio(AudioClip clip)
    {
        AudioSource audio = this.GetComponentInParent<AudioSource>();
        audio.clip = clip;
        audio.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "RoomSpace":
                PlayNarationAudio(spaceClip);
                break;
            case "RoomJungle":
                PlayNarationAudio(jungleClip);
                break;
            case "RoomArctic":
                PlayNarationAudio(arcticClip);
                break;
            case "RoomCoastal":
                PlayNarationAudio(coastalClip);
                break;
            case "RoomMain":
                if (!hasMainIntroBeenPlayed)
                {
                    PlayNarationAudio(mainClip);
                }
                hasMainIntroBeenPlayed = true;
                break;
            default:
                break;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        string tag = other.gameObject.tag;
        if(tag == "RoomSpace" || tag == "RoomJungle" || tag == "RoomArctic" || tag == "RoomCoastal" || tag == "RoomMain")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Stop();
        }
    }
}
