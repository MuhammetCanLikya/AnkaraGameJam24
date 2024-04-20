using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryAndShoot : MonoBehaviour
{
    public GameObject bullet;
    public float forceMagnitude = 100f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Sol týklama (0) algýlandýðýnda
        {
            // Fare pozisyonunu al
            Vector3 mousePosition = Input.mousePosition;
            // Fare pozisyonunu dünya koordinatlarýna dönüþtür
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));

            // Objeyi instantiate et
            GameObject obj = Instantiate(bullet, worldPosition, Quaternion.identity);

            // Objeye bir kuvvet uygula
            Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // Ýleri doðru kuvvet uygula (objenin x ekseni boyunca)
                rb.AddForce(new Vector3(0,1,1) * -forceMagnitude, ForceMode2D.Impulse);
            }
            else
            {
                Debug.LogWarning("Instantiate edilen obje üzerinde bir Rigidbody2D bileþeni bulunamadý!");
            }
        }


        /*
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.DrawLine(ray.origin, hit.point);
        }
        Vector3 Dir = (hit.point - transform.position);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
        GameObject go = Instantiate(bullet, this.gameObject.transform);
            go.GetComponent<Rigidbody>().AddForce(Dir * -Time.deltaTime);
        }*/
    }
}
