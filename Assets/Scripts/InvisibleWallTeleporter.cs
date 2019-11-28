using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWallTeleporter : MonoBehaviour
{
    public float teleportPositionX;
    public float teleportPostitionY;
    public float teleportPostitionZ;
    
    private void OnTriggerEnter(Collider other)
    {
        var otherObject = other.gameObject;
        Debug.Log(otherObject.name);

        if (otherObject.tag == "Player")
        {
            otherObject.transform.position = new Vector3(teleportPositionX, teleportPostitionY, teleportPostitionZ);
        }
    }
}
