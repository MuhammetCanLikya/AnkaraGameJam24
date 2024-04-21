using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject engelPrefab; // Engel prefab'ý
    public GameObject engelsizPrefab;

    public GameObject cevrePrefab;

    public GameObject character;
    public float oluþturmaAralýðý = 2f; // Engel oluþturma aralýðý
    public float yükseklik = 1f; // Yükseklik
    public float xSýnýrlarý = 4f; // Engel oluþturma sýnýrlarý
    public int objeUzunlugu = 10; // Engel oluþturma sýnýrlarý
    public int renderSýklýðý = 3;
    private float SpeedOfCharacter = 5f;

    private float zamanSayacý = 0f; // Zaman sayacý

    public float zDifferenceThreshold = 5f; // Threshold for z-position difference to destroy GameObject

    // Update is called once per frame
    void Update()
    {
        // Zaman sayacýný arttýr
        zamanSayacý += Time.deltaTime;

        // Belirli bir aralýkta engel oluþtur
        if (zamanSayacý >= oluþturmaAralýðý)
        {
            OluþturEngel();
            zamanSayacý = 0f;
        }
        character.transform.Translate(new Vector3(0, 0, SpeedOfCharacter *Time.deltaTime));
        // Check if both cube1 and engelPrefab are assigned
        //if (engelPrefab.transform.position.z < cube1.transform.position.z)
            //Destroy(engelPrefab);
    }
    void OluþturEngel()
    {


        // Engel pozisyonunu oluþtur
        Vector3 engelPozisyonu = new Vector3(transform.position.x, transform.position.y, 
            transform.position.z + objeUzunlugu+ character.transform.position.z + 65); 

        if (renderSýklýðý == 0)
        {
            // Engel prefab'ýný oluþtur
            GameObject yeniEngel = Instantiate(engelPrefab,
            new Vector3(engelPozisyonu.x, engelPozisyonu.y, engelPozisyonu.z), Quaternion.identity);
            yeniEngel.transform.Rotate(new Vector3(0, 0, Random.Range(0, 4) * 90f));

            renderSýklýðý = 3;
        }
        else
        {
                 Instantiate(engelsizPrefab,
            new Vector3(engelPozisyonu.x, engelPozisyonu.y, engelPozisyonu.z), Quaternion.identity);

            renderSýklýðý--;
        }
        
    }
    

    
}
