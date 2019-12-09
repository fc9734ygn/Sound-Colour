using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    GameObject player;
    private void Start()
    {
      
        player = GameObject.Find("playerFinal");
        if (player != null)
        {
            DontDestroyOnLoad(player);
        }

    }

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
        SceneManager.LoadScene("CentralRoom");
    }
}
