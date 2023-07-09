
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
        bldManager.SetTowerToBuild(bldManager.stdTowerPrefab);
        bldManager.towerToBuild = bldManager.stdTowerPrefab;
    }

    public void PurchaseAnotherTurret()
    {
        bldManager.SetTowerToBuild(bldManager.anotherTowerPrefab);
        bldManager.towerToBuild = bldManager.anotherTowerPrefab;
    }
}
