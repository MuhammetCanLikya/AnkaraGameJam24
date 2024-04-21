using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject engelPrefab; // Engel prefab'�
    public GameObject engelsizPrefab;

    public GameObject cevrePrefab;

    public GameObject character;
    public float olu�turmaAral��� = 2f; // Engel olu�turma aral���
    public float y�kseklik = 1f; // Y�kseklik
    public float xS�n�rlar� = 4f; // Engel olu�turma s�n�rlar�
    public int objeUzunlugu = 10; // Engel olu�turma s�n�rlar�
    public int renderS�kl��� = 3;
    private float SpeedOfCharacter = 5f;

    private float zamanSayac� = 0f; // Zaman sayac�

    public float zDifferenceThreshold = 5f; // Threshold for z-position difference to destroy GameObject

    // Update is called once per frame
    void Update()
    {
        // Zaman sayac�n� artt�r
        zamanSayac� += Time.deltaTime;

        // Belirli bir aral�kta engel olu�tur
        if (zamanSayac� >= olu�turmaAral���)
        {
            Olu�turEngel();
            zamanSayac� = 0f;
        }
        character.transform.Translate(new Vector3(0, 0, SpeedOfCharacter *Time.deltaTime));
        // Check if both cube1 and engelPrefab are assigned
        //if (engelPrefab.transform.position.z < cube1.transform.position.z)
            //Destroy(engelPrefab);
    }
    void Olu�turEngel()
    {


        // Engel pozisyonunu olu�tur
        Vector3 engelPozisyonu = new Vector3(transform.position.x, transform.position.y, 
            transform.position.z + objeUzunlugu+ character.transform.position.z + 65); 

        if (renderS�kl��� == 0)
        {
            // Engel prefab'�n� olu�tur
            GameObject yeniEngel = Instantiate(engelPrefab,
            new Vector3(engelPozisyonu.x, engelPozisyonu.y, engelPozisyonu.z), Quaternion.identity);
            yeniEngel.transform.Rotate(new Vector3(0, 0, Random.Range(0, 4) * 90f));

            renderS�kl��� = 3;
        }
        else
        {
                 Instantiate(engelsizPrefab,
            new Vector3(engelPozisyonu.x, engelPozisyonu.y, engelPozisyonu.z), Quaternion.identity);

            renderS�kl���--;
        }
        
    }
    

    
}
