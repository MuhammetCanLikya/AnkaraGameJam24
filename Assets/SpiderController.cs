using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class SpiderController : MonoBehaviour
{
    public GameObject ball;
    public GameObject explosionEffect;

    public GameObject explosionParticle;

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

        explosionParticle.gameObject.SetActive(true);
        this.transform.DOScale(new Vector3(0f, 0f, 0f), 1f)
        .SetEase(Ease.OutQuad); // Apply ease effect (optional)




        //Saðlýk sistemi
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
