using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mycameraController : UnityEngine.MonoBehaviour
{
    [SerializeField]
    private float camSpeed;
    [SerializeField]
    private float scrollVelocity;

    public float minY = 10.0f;
    public float maxY = 81.0f;
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

        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.right * camSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.left * camSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 900 * scrollVelocity * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;
    }
}

