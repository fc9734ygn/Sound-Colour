using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballInteractable : MonoBehaviour
{

    public void OnThrow()
    {
        StartCoroutine(DespawnCoroutine());
    }

    IEnumerator DespawnCoroutine()
    {
        yield return new WaitForSeconds(60);
        Destroy(gameObject);
    }
}
