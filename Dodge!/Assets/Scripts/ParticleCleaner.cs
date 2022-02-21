using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCleaner : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Elimination());
    }
    IEnumerator Elimination()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
