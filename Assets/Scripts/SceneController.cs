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

        player.transform.position = new Vector3(0, 1.5f, 2000);
        SceneManager.LoadScene("CoastalRoom", LoadSceneMode.Additive);
        Destroy(GameObject.Find("MainRoom"));
    }

    public void LoadJungleScene()
    {

        SceneManager.LoadScene("Jungle", LoadSceneMode.Additive);
        Destroy(GameObject.Find("MainRoom"));

    }

    public void LoadArcticScene()
    {
        SceneManager.LoadScene("Arctic", LoadSceneMode.Additive);

        player.transform.position = new Vector3(10000, 1.5f, 0);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Arctic"));
        Destroy(GameObject.Find("MainRoom"));

    }

    public void LoadSpaceScene()
    {
        player.transform.position = new Vector3(5000, 1.5f, 5000);
        SceneManager.LoadScene("Space", LoadSceneMode.Additive);
        Destroy(GameObject.Find("MainRoom"));

    }

    public void LoadMainScene()
    {
        player.transform.position = new Vector3(0, 0, 0);
        SceneManager.LoadScene("CentralRoom", LoadSceneMode.Additive);
        Destroy(GameObject.Find("SpaceRoom"));
        Destroy(GameObject.Find("ArcticRoom"));
        Destroy(GameObject.Find("JungleRoom"));
        Destroy(GameObject.Find("CoastalRoom"));
    }
}
