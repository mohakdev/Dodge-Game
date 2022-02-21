using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;
    void Start()
    {
        StartCoroutine(GenerateEnemies());
    }
    IEnumerator GenerateEnemies()
    {
        while (true)
        {
            Vector3 SpawnPos = new Vector3(Random.Range(-7, 8), 18, 0);
            GameObject ClonedEnemy = Instantiate(Enemy, SpawnPos, transform.rotation);
            yield return new WaitForSeconds(1);
        }
    }
}