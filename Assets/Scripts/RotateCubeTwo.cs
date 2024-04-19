using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class RotateCubeTwo : MonoBehaviour
{

    public Transform cubeTwo;

    private bool isRotating = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRotating)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                RotateCube(90);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                RotateCube(-90);
            }
        }

    }
    void RotateCube(int angle)
    {
        isRotating = true;

        Quaternion targetRotation = Quaternion.Euler(0, 0, cubeTwo.transform.localRotation.eulerAngles.z + angle);
        transform.DORotateQuaternion(targetRotation, 1).OnComplete(() => isRotating = false);

        Debug.Log(cubeTwo.transform.localRotation.z + angle);
    }





}
