using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public GameObject myCamera;

    void Start()
    {
        myCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        transform.rotation = (myCamera.transform.rotation);
    }
}
// https://www.youtube.com/watch?v=_lREXfAMUcE
