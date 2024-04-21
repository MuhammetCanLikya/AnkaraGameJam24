using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
    public GameObject ball;
    public GameObject explosionEffect;

    public ParticleSystem explosionParticle;

    private void Start()
    {
        
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball") {
            explosionEffect.SetActive(true);
            StartCoroutine(DestroyBall());
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        
            explosionParticle.Play();
            Destroy(gameObject);
        if (other.gameObject.CompareTag("Player"))
        {
            // Oyuncu nesnesine çarpýþma algýlandýðýnda canýný azalt
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(10);
            }
        }

    }

    IEnumerator DestroyBall()
    {
        yield return new WaitForSeconds(1);
        Destroy(explosionEffect);
    }

}
