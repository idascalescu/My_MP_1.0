using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class btCollisions : MonoBehaviour
{
    GameManager gM;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            this.gameObject.SetActive(false);
            //Destroy(collision.rigidbody);
            gM.playerHP--;
            Debug.Log("You've got KNOCKED !!! PROTECT YOUR TEMPLE !!!");
        }
    }
}
