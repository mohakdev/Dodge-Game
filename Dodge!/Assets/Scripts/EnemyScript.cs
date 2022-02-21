using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public ParticleSystem particle;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Ground")
        {
            ParticleSystem ClonedParticle = Instantiate(particle, transform.position, transform.rotation);
            ClonedParticle.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
