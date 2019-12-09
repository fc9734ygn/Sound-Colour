using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MainRoomDropZone : MonoBehaviour
{
    //Spawning deco in room once orb is dropped.
    public GameObject articStuff;
    public GameObject jungleStuff;
    public GameObject spaceStuff;
    public GameObject coastalStuff;

    //Turning off lights once ball is dropped. 
    public GameObject coastalLight;
    public GameObject articLight;
    public GameObject jungleLight;
    public GameObject spaceLight;


    //Level complete nosie 
    public AudioClip BallDropped;

    public void OnRewardBallSnap()
    {
        GameObject snappedObject = gameObject.GetComponent<VRTK_SnapDropZone>().GetCurrentSnappedObject();
        RewardBall.Roomtype type = snappedObject.GetComponent<RewardBall>().roomtype;

        switch (type)
        {
            case RewardBall.Roomtype.Arctic:
                articLight.SetActive(false);
                articStuff.SetActive(true);
                AudioSource.PlayClipAtPoint(BallDropped, transform.position);
                snappedObject.transform.position = new Vector3(0, 0, 0);
                break;
            case RewardBall.Roomtype.Coastal:
                coastalLight.SetActive(false);
                coastalStuff.SetActive(true);
                break;
            case RewardBall.Roomtype.Jungle:
                jungleLight.SetActive(false);
                jungleStuff.SetActive(true);
                break;
            case RewardBall.Roomtype.Space:
                spaceLight.SetActive(false);
                spaceStuff.SetActive(true);
                break;
            default:
                break;
        }
    }
}
