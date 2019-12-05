using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballSpawner : MonoBehaviour
{
    public GameObject prefab;

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Snowball")
        {
            StartCoroutine(SpawnCoroutine());
        }
    }

    IEnumerator SpawnCoroutine()
    {
        yield return new WaitForSeconds(3);
        Instantiate(prefab, transform.position, Quaternion.Euler(0, 0, 0));
    }
}
