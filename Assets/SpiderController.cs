using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpiderController : MonoBehaviour
{
    public GameObject ball;
    public GameObject explosionEffect;

    public GameObject explosionParticle;
    GameObject _hitScreen;

    private void Start()
    {
        _hitScreen = GameObject.FindWithTag("Image2");
    }

    private void Update()
    {
        //update in i�inde yaz�lacak
        if (_hitScreen != null)
        {
            if (_hitScreen.GetComponent<Image>().color.a > 0)
            {
                var color = _hitScreen.GetComponent<Image>().color;
                color.a -= 0.02f;
                _hitScreen.GetComponent<Image>().color = color;
            }
        }
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

        if (other.gameObject.CompareTag("ball")) { 
        explosionParticle.gameObject.SetActive(true);
        this.transform.DOScale(new Vector3(0f, 0f, 0f), 1f)
        .SetEase(Ease.OutQuad); // Apply ease effect (optional)
        }



        //Sa�l�k sistemi
        if (other.gameObject.CompareTag("Player"))
        {
            gotHurt();
            Debug.Log("�r�mcekle Karakter �arp��t�");

            // Oyuncu nesnesine �arp��ma alg�land���nda can�n� azalt
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
    //player�n �r�mce�e �arpt��� yerde bu fonksiyon �a�r�lacak
    void gotHurt()
    {
        var color = _hitScreen.GetComponent<Image>().color;
        color.a = 0.4f;
        _hitScreen.GetComponent<Image>().color = color;

    }
}
