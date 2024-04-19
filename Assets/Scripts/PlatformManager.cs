using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject engelPrefab; // Engel prefab'ý
    public GameObject character;
    public float oluþturmaAralýðý = 2f; // Engel oluþturma aralýðý
    public float yükseklik = 1f; // Yükseklik
    public float xSýnýrlarý = 4f; // Engel oluþturma sýnýrlarý
    public int objeUzunlugu = 10; // Engel oluþturma sýnýrlarý

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
        character.transform.Translate(new Vector3(0, 0, 5*Time.deltaTime));
        // Check if both cube1 and engelPrefab are assigned
        //if (engelPrefab.transform.position.z < cube1.transform.position.z)
            //Destroy(engelPrefab);
    }
    void OluþturEngel()
    {


        // Engel pozisyonunu oluþtur
        Vector3 engelPozisyonu = new Vector3(transform.position.x, transform.position.y, 
            transform.position.z + objeUzunlugu+ character.transform.position.z);

        // Engel prefab'ýný oluþtur
        GameObject yeniEngel = Instantiate(engelPrefab, new Vector3(engelPozisyonu.x,engelPozisyonu.y,), Quaternion.identity);

        
    }
}
