using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MainRoomDropZone : MonoBehaviour
{

    public GameObject articStuff;
    public GameObject jungleStuff;
    public GameObject spaceStuff;
    public GameObject coastalStuff;

    public GameObject coastalLight;
    public GameObject articLight;
    public GameObject jungleLight;
    public GameObject spaceLight;

    public void OnRewardBallSnap()
    {
        GameObject snappedObject = gameObject.GetComponent<VRTK_SnapDropZone>().GetCurrentSnappedObject();
        RewardBall.Roomtype type = snappedObject.GetComponent<RewardBall>().roomtype;

        switch (type)
        {
            case RewardBall.Roomtype.Arctic:
                articLight.SetActive(false);
                articStuff.SetActive(true);
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
