using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;
    public float WaitTime;
    void Start()
    {
        StartCoroutine(GenerateEnemies());
    }
    IEnumerator GenerateEnemies()
    {
        while (true)
        {
            Vector3 SpawnPos = new Vector3(Random.Range(-7, 8), transform.position.y, 0);
            GameObject ClonedEnemy = Instantiate(Enemy, SpawnPos, transform.rotation);
            yield return new WaitForSeconds(WaitTime);
            if (WaitTime > 0.7f)
            {
                WaitTime -= 0.01f;
            }
        }
    }
}
