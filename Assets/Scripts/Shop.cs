
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager bldManager;

    private void Start()
    {
        bldManager = BuildManager.instance;
    }

    public void PurchaseFTower()
    {
        Debug.Log("Standard tower purchased");
        bldManager.SetTowerToBuild(bldManager.stdTowerPrefab);
        bldManager.towerToBuild = bldManager.stdTowerPrefab;
    }

    public void PurchaseAnotherTurret()
    {
        Debug.Log("Another tower purchased");
        bldManager.SetTowerToBuild(bldManager.anotherTowerPrefab);
        bldManager.towerToBuild = bldManager.anotherTowerPrefab;
    }
}
