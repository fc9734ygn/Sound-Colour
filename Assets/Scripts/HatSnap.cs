using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatSnap : MonoBehaviour
{
    public GameObject invisibleSnowman;

    public void OnSnap()
    {
        invisibleSnowman.GetComponent<Snowman>().Activate();
    }
    
}
