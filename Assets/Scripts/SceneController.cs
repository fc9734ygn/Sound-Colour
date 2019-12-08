using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    
    public void LoadCoastalScene()
    {
        SceneManager.LoadScene("CoastalRoom");
    }

    public void LoadJungleScene()
    {
        SceneManager.LoadScene("Jungle");
    }

    public void LoadArcticScene()
    {
        SceneManager.LoadScene("Arctic");
    }

    public void LoadSpaceScene()
    {
        SceneManager.LoadScene("Space");
    }

    public void LoadMainScene()
    {
        var rewardBall = GameObject.Find("RewardBall");
        DontDestroyOnLoad(rewardBall);
        SceneManager.LoadScene("CentralRoom");
    }
}
