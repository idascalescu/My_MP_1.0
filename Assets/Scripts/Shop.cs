
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TowerBluePrint standardTower;
    public TowerBluePrint sTower2;
    //Another type of tower.

    BuildManager bldManager;

    private void Start()
    {
        bldManager = BuildManager.instance;
    }

    public void SelectSTDTower()
    {
        Debug.Log("Standard tower selected...");
        bldManager.SelectTowerToBuild(standardTower);
    }
    public void SelectFTTower()
    {
        bldManager.SelectTowerToBuild(sTower2);
    }

   /* public void PurchaseAnotherTurret()
    {
        bldManager.SetTowerToBuild(bldManager.anotherTowerPrefab);
        bldManager.towerToBuild = bldManager.anotherTowerPrefab;
    } // HIGH PRIORITY*/
}
