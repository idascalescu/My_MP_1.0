using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NodeScrpt : MonoBehaviour
{
    public Color hoverColor;

    private GameObject tower;

    private Renderer myRend;
    private Color startColor;

    BuildManager buildManager;

    private void Start()
    {
         myRend = GetComponent<Renderer>();
        startColor = myRend.material.color;
        buildManager = BuildManager.instance;
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTowerToBuild() == null)
        {
            return;
        }

        if(tower  != null) 
        {
            return;
        }

        //build the tower
        GameObject towerToBuild = buildManager.GetTowerToBuild();
        tower = (GameObject)Instantiate(towerToBuild, 
            transform.position + new Vector3(0.0f, 0.8f, 0.0f), 
            transform.rotation);

    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (buildManager.GetTowerToBuild() == null)
        {
            return;
        }
        myRend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        myRend.material.color = startColor;
    }
}
