using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballInteractable : MonoBehaviour
{

    public GameObject snowballPrefab;
    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;
    }


    private void SpawnAnother()
    {
        Instantiate(snowballPrefab, originalPosition, Quaternion.Euler(0,0,0));
    }

    public void OnThrow()
    {
        SpawnAnother();
      //  Destroy(gameObject);
    }
}
