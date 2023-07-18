using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NodeScript : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 posOffSet;

    [Header("Optional")]
    public GameObject tower;

    private Renderer myRend;
    private Color startColor;

    BuildManager buildManager;

    private void Start()
    {
         myRend = GetComponent<Renderer>();
        startColor = myRend.material.color;
        buildManager = BuildManager.instance;
        posOffSet = new Vector3(0.0f, .8f, 0.0f);
    }

    public Vector3 GetBuildPos()
    {
        return transform.position + posOffSet;
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
        {
            return;
        }

        if (tower != null)
        {
            return;
        }

        //build the tower
        buildManager.BuiltTowerOn(this);

    } //MUST BE FIXED TOMORROW THE LATEST HIGH PRIORITY

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (!buildManager.CanBuild)
        {
            return;
        }
        myRend.material.color = hoverColor;
    } // HIGH PRIORITY

    private void OnMouseExit()
    {
        myRend.material.color = startColor;
    }
}
