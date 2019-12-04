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
        Instantiate(snowballPrefab, originalPosition + new Vector3(0, 0.5f, 0), Quaternion.Euler(0, 0, 0));
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "snowballSpawn")
        {
            //TODO fix this
               SpawnAnother();
        }
    }

    public void OnThrow()
    {
       // SpawnAnother();
        StartCoroutine(DespawnCoroutine());
    }


    IEnumerator DespawnCoroutine()
    {
        yield return new WaitForSeconds(60);
        Destroy(gameObject);
    }
}
