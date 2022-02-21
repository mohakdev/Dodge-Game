using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    ParticleSystem particle;
    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Instantiate(particle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
