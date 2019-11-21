using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravityObject : MonoBehaviour
{
    public bool shouldRotate;
    public bool shouldFloat;

    private float floatingDefaultPositionY;
    private float floatingDeviationY;
    private float floatSpeed;
    private readonly float rotationSpeed = 1;


    private void Start()
    {
        floatingDeviationY = Random.Range(0.5f, 1f);
        floatSpeed = Random.Range(0.5f, 1f);
        floatingDefaultPositionY = transform.position.y - floatingDeviationY;
    }

    void FixedUpdate()
    {
        if (shouldFloat)
        {
            ApplyFloating();
        }

        if (shouldRotate)
        {
            ApplyRotation();
        }
    }

    private void ApplyRotation()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void ApplyFloating()
    {
        Vector3 vector = new Vector3(0, 0, 0);

        if (transform.position.y < floatingDefaultPositionY)
        {
            vector = Vector3.up;
        }
        else
        {
            vector = Vector3.down;
        }

        transform.GetComponent<Rigidbody>().AddForce(vector * floatSpeed);
    }

    public void ToggleFloating(bool shouldFloat)
    {
        bool isGravityOn = transform.GetComponent<Rigidbody>().useGravity;
        transform.GetComponent<Rigidbody>().useGravity = !shouldFloat;
        shouldRotate = false;
    }
}