using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoastReward : MonoBehaviour
{
    public GameObject GreenLight;
    public GameObject BlueLight;
    public GameObject OrangeLight;
    public GameObject RewardBall;
    public GameObject InactiveRewardBall;
    public GameObject GlassJar;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    void RewardCheck()
    {

        if (GreenLight.active == true && BlueLight.active == true && OrangeLight.active == true)
        {
            RewardBall.GetComponent<MeshRenderer>().enabled = true;
            InactiveRewardBall.active = false;
            GlassJar.active = false;
            

        }

    }

    // Update is called once per frame
    void Update()
    {
        RewardCheck();
    }
}
