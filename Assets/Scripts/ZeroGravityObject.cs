using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravityObject : MonoBehaviour
{

    private float floatingDefaultPositionY;
    private readonly float floatingDeviationY = 0.5f;
    private readonly float floatSpeed = 0.25f;
    private readonly float rotationSpeed = 1;


    private void Start()
    {
        floatingDefaultPositionY = transform.position.y - floatingDeviationY;
    }

    void FixedUpdate()
    {
        ApplyZeroGravityEffect();
    }

    private void ApplyZeroGravityEffect()
    {
        Vector3 vector = new Vector3(0, 0, 0);

        if (transform.position.y < floatingDefaultPositionY)
        {
            vector = Vector3.up;
        }
        else if (transform.position.y >= floatingDefaultPositionY)
        {
            vector = Vector3.down;
        }

        transform.GetComponent<Rigidbody>().AddForce(vector * floatSpeed);
        transform.Rotate(rotationSpeed, rotationSpeed, rotationSpeed);
    }

    public void ToggleGravity()
    {
        bool isGravityOn = transform.GetComponent<Rigidbody>().useGravity;
        transform.GetComponent<Rigidbody>().useGravity = true;
    }
}