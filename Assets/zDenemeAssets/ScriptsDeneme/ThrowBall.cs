using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    // Kuvvetin büyüklüðü
    private float impulseForce = 10f;

    // Cismin RigidBody bileþeni
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody bileþenini al
        rb = GetComponent<Rigidbody>();

        // Cisme darbe uygula (impulse)
        rb.AddForce(new Vector3(0,10,5) * impulseForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
