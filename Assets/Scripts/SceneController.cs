using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    GameObject player;

    public Material JungleSkybox;
    public Material SpaceSkybox;
    public Material ArcticSkybox;
    public Material CoastalSkybox;

    private void Start()
    {
        player = GameObject.Find("playerFinal");
    }

    public void LoadCoastalScene()
    {
        RenderSettings.skybox = CoastalSkybox;

        player.transform.position = new Vector3(0, 1.5f, 2000);
        SceneManager.LoadScene("CoastalRoom", LoadSceneMode.Additive);
    }

    public void LoadJungleScene()
    {
        RenderSettings.skybox = JungleSkybox;
        player.transform.position = new Vector3(2002, 1.5f, 2002);
        SceneManager.LoadScene("Jungle", LoadSceneMode.Additive);

    }

    public void LoadArcticScene()
    {
        player.transform.position = new Vector3(10000, 1.5f, 0);
        SceneManager.LoadScene("Arctic", LoadSceneMode.Additive);
        RenderSettings.skybox = ArcticSkybox;

    }

    public void LoadSpaceScene()
    {
        RenderSettings.skybox = SpaceSkybox;
        player.transform.position = new Vector3(5000, 1.5f, 5000);
        SceneManager.LoadScene("Space", LoadSceneMode.Additive);
    }

    public void LoadMainScene()
    {
        player.transform.position = new Vector3(0, 0, 0);
        Destroy(GameObject.Find("SpaceRoom"));
        Destroy(GameObject.Find("ArcticRoom"));
        Destroy(GameObject.Find("JungleRoom"));
        Destroy(GameObject.Find("CoastalRoom"));
    }
}
