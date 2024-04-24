using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeniBirKod : MonoBehaviour
{
    public GameObject health1a;
    public GameObject health1b;
    public GameObject health2a;
    public GameObject health2b;
    public GameObject health3a;
    public GameObject health3b;

    private int currentHealth = 3; // Baþlangýçta 3 can var

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Oyuncu caný azaldýðýnda bir caný kaybet
            currentHealth--;

            // Oyuncunun kalan can sayýsýna göre uygun sprite'larý göster
            UpdateHealthUI();
        }
    }

    private void UpdateHealthUI()
    {
        // Tüm sprite'larý pasifleþtir
        health1a.SetActive(false);
        health1b.SetActive(false);
        health2a.SetActive(false);
        health2b.SetActive(false);
        health3a.SetActive(false);
        health3b.SetActive(false);

        // Kalan can sayýsýna göre uygun sprite'larý aktifleþtir
        switch (currentHealth)
        {
            case 3:
                health3a.SetActive(true);
                health2a.SetActive(true);
                health1a.SetActive(true);
                health3b.SetActive(false);
                health2b.SetActive(false);
                health1b.SetActive(false);
                break;
            case 2:
                health3a.SetActive(false);
                health2a.SetActive(true);
                health1a.SetActive(true);
                health3b.SetActive(true);
                health2b.SetActive(false);
                health1b.SetActive(false);
                break;
            case 1:
                health3a.SetActive(false);
                health2a.SetActive(false);
                health1a.SetActive(true);
                health3b.SetActive(true);
                health2b.SetActive(true);
                health1b.SetActive(false);
                break;
            case 0:
                health3a.SetActive(false);
                health2a.SetActive(false);
                health1a.SetActive(false);
                health3b.SetActive(true);
                health2b.SetActive(true);
                health1b.SetActive(true);
                Debug.Log("Oyuncu öldü!");
                Time.timeScale = 0;



                break;
            default:
                Debug.Log("Oyuncu öldü!"); // Tüm canlar bittiðinde burada uygun iþlemler yapýlabilir
                break;
        }
    }
}
