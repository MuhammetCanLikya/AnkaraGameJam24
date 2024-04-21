using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class DestroyEnvironment : MonoBehaviour
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
        if (this.gameObject.transform.position.z + intervalOfPlatform+400 < character.transform.position.z)
        {
                Destroy(this.gameObject);
        }
    }
}
