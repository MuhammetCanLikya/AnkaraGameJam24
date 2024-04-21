using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentInstantiator : MonoBehaviour
{
    public GameObject terrain;
    public GameObject character;
    private int objeUzunlugu = 374;
    private float intervalOfPlatform = 0;
    private float zamanSayac� = 0f;
    public float olu�turmaAral��� = 80f;
    private void Start()
    {
        intervalOfPlatform = terrain.GetComponent<Transform>().localScale.z / 2;
        character = GameObject.Find("character");
    }

    // Update is called once per frame
    void Update()
    {

        // Zaman sayac�n� artt�r
        zamanSayac� += Time.deltaTime;

        // Belirli bir aral�kta engel olu�tur
        if (zamanSayac� >= olu�turmaAral���)
        {
            InstantiatePlatform();
            zamanSayac� = 0f;
        }


    }

    

    private void InstantiatePlatform()
    {
        Vector3 engelPozisyonu = new Vector3(transform.position.x, transform.position.y,
            transform.position.z  + objeUzunlugu + character.transform.position.z);

        Instantiate(terrain,
            new Vector3(engelPozisyonu.x, engelPozisyonu.y, engelPozisyonu.z), Quaternion.identity);

    }


}
