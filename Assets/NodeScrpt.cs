using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeScrpt : MonoBehaviour
{
    public Color hoverColor;

    private GameObject tower;

    private Renderer myRend;
    private Color startColor;

    private void Start()
    {
         myRend = GetComponent<Renderer>();
        startColor = myRend.material.color;
    }

    private void OnMouseDown()
    {
        if(tower  != null) 
        {
            Debug.Log("Can't build in ther yo...");
            return;
        }

        //build the tower
        GameObject towerToBuild = BuildManager.instance.
            GetTowerToBuild();
        tower = (GameObject)Instantiate(towerToBuild, 
            transform.position + new Vector3(0.0f, 0.8f, 0.0f), 
            transform.rotation);

    }

    private void OnMouseEnter()
    {
        myRend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        myRend.material.color = startColor;
    }
}
