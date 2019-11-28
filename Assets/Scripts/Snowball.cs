using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    public GameObject rightController;
    public GameObject snowballPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(snowballPrefab, rightController.transform.position, Quaternion.Euler(0, 0, 0));
        gameObject.SetActive(false);
    }
}
