using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public GameObject character;
    [SerializeField]
    private int intervalOfPlatform = 15;

    
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("character");
    }

    // Update is called once per frame
    void Update()
    {

        if(this.gameObject.transform.position.z + intervalOfPlatform  < character.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
