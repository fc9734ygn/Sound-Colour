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

    private bool canTeleport = true;

    private void Start()
    {
        player = GameObject.Find("playerFinal");
      
       
    }

    private void EnableMusic()
    {
        AudioSource mainMusic = GameObject.Find("ambienceMusic").GetComponent<AudioSource>();
        mainMusic.Play();
    }

    private void DisableMusic()
    {
        AudioSource mainMusic = GameObject.Find("ambienceMusic").GetComponent<AudioSource>();
        mainMusic.Stop();
    }

    public void LoadCoastalScene()
    {
        if (canTeleport)
        {
            DisableMusic();
            RenderSettings.skybox = CoastalSkybox;
            SceneManager.LoadScene("CoastalRoom", LoadSceneMode.Additive);
            player.transform.position = new Vector3(0, 1.5f, 2000);
            StartCoroutine(TeleportCooldown());
        }

    }

    public void LoadJungleScene()
    {
        if (canTeleport)
        {
            DisableMusic();

            RenderSettings.skybox = JungleSkybox;
            SceneManager.LoadScene("Jungle", LoadSceneMode.Additive);
            player.transform.position = new Vector3(2002, 1.5f, 2002);
            StartCoroutine(TeleportCooldown());
        }
    }

    public void LoadArcticScene()
    {
        if (canTeleport)
        {
            DisableMusic();

            RenderSettings.skybox = ArcticSkybox;
            SceneManager.LoadScene("Arctic", LoadSceneMode.Additive);
            player.transform.position = new Vector3(10000, 1.5f, 0);
            StartCoroutine(TeleportCooldown());
        }
    }

    public void LoadSpaceScene()
    {
        if (canTeleport)
        {
            DisableMusic();

            RenderSettings.skybox = SpaceSkybox;
            SceneManager.LoadScene("Space", LoadSceneMode.Additive);
            player.transform.position = new Vector3(5000, 1.5f, 5000);
            StartCoroutine(TeleportCooldown());
        }
    }

    public void LoadMainScene()
    {
        if (canTeleport)
        {
            EnableMusic();

            player.transform.position = new Vector3(0, 0, 0);
            Destroy(GameObject.Find("SpaceRoom"));
            Destroy(GameObject.Find("ArcticRoom"));
            Destroy(GameObject.Find("JungleRoom"));
            Destroy(GameObject.Find("CoastalRoom"));
            StartCoroutine(TeleportCooldown());
        }
    }

    IEnumerator TeleportCooldown()
    {
        canTeleport = false;
        yield return new WaitForSeconds(3);
        canTeleport = true;
    }
}
