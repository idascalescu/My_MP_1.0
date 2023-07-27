using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRotation : UnityEngine.MonoBehaviour
{
    [SerializeField]
    private float rotSpeed;

    public Vector3 rotation;

    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime * rotSpeed);
    }
}
//Thanks to Morgan for the source code on gitHub for the level 5 team project
