using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentInstantiator : MonoBehaviour
{
    public GameObject terrain;
    public GameObject character;
    private int objeUzunlugu = 374;
    private float intervalOfPlatform = 0;
    private float zamanSayacý = 0f;
    public float oluþturmaAralýðý = 80f;
    private void Start()
    {
        intervalOfPlatform = terrain.GetComponent<Transform>().localScale.z / 2;
        character = GameObject.Find("character");
    }

    // Update is called once per frame
    void Update()
    {

        // Zaman sayacýný arttýr
        zamanSayacý += Time.deltaTime;

        // Belirli bir aralýkta engel oluþtur
        if (zamanSayacý >= oluþturmaAralýðý)
        {
            InstantiatePlatform();
            zamanSayacý = 0f;
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
