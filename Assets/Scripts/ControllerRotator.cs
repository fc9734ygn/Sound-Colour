using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

[RequireComponent(typeof(VRTK_ControllerEvents))]
public class ControllerRotator : MonoBehaviour
{

    // controller events
    VRTK_ControllerEvents controlEv;
    public GameObject playerCamera;
    public GameObject player;
    private bool playerIsBig = false;

    void Awake()
    {
        // get VRTK controller event component
        controlEv = GetComponent<VRTK_ControllerEvents>();
    }

    void OnEnable()
    {
        
        // event listening
        controlEv.ButtonTwoPressed += RotatePlayer;
        controlEv.ButtonOnePressed += ScalePlayer;
    }

    void OnDisable()
    {
        // removing event listeners
       controlEv.ButtonTwoPressed -= RotatePlayer;
       controlEv.ButtonOnePressed -= ScalePlayer;
    }

    void RotatePlayer(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("button 2 pressed");
        playerCamera.transform.Rotate(playerCamera.transform.rotation.x, playerCamera.transform.rotation.y + 180f, playerCamera.transform.rotation.z, Space.Self);
    }

    void ScalePlayer(object sender, ControllerInteractionEventArgs e)
    {
        if (!playerIsBig)
        {
            Debug.Log("scalling player up");

            player.transform.localScale += new Vector3(10, 10, 10);

        }
        else
        {
            Debug.Log("scalling player down");

            player.transform.localScale -= new Vector3(10, 10, 10);
        }

        playerIsBig = !playerIsBig;
    }
}