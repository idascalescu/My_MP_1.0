using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mycameraController : MonoBehaviour
{
    [SerializeField]
    private float camSpeed;
    private void Update()
    {
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.forward * camSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.back * camSpeed * Time.deltaTime, Space.World);
        }
    }
}

