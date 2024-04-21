using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
    public GameObject ball;
    GameObject explosionEffect;


    private void Start()
    {
        ball = GameObject.FindWithTag("explosion");
        if(explosionEffect is not null)
        {
            explosionEffect = ball.GetComponent<GameObject>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball") {
            explosionEffect.SetActive(true);
            StartCoroutine(DestroyBall());
        }
    }

    IEnumerator DestroyBall()
    {
        yield return new WaitForSeconds(1);
        Destroy(explosionEffect);
    }

}
