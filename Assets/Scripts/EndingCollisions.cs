using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndingCollisions : MonoBehaviour
{
    GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BTPrefab")
        {
            Debug.Log("BT Reached finnish");
            Destroy(collision.gameObject);
            gameManager.TakeDamage(1);
        }
    }
}
