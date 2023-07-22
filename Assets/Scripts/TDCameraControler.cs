using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TDCameraControler : MonoBehaviour//LOW PRIORITY
{
    public float flatMovementSpeed = 28.0f;
    public float flatMovementThickness = 10.0f;

    private bool isMoving = true;

    public float scrollVelocity = 5.3f;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isMoving = !isMoving;
        }

        if(!isMoving ) { return; }

        if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - flatMovementThickness)
        {
            transform.Translate(Vector3.forward * flatMovementSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= flatMovementThickness)
        {
            transform.Translate(Vector3.back * flatMovementSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("a") || Input.mousePosition.x <= Screen.width - flatMovementThickness)
        {
            transform.Translate(Vector3.right * flatMovementSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - flatMovementThickness)
        {
            transform.Translate(Vector3.left * flatMovementSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 900 * scrollVelocity * Time.deltaTime;
        /*pos.y = Mathf.Clamp(pos.y, minY, maxY);*/

        transform.position = pos;
    }
}
