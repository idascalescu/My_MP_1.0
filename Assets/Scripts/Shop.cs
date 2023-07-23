
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TowerBluePrint sTower1;
    public TowerBluePrint sTower2;
    public TowerBluePrint sTower3;
    //Another type of tower.

    BuildManager bldManager;

    private void Start()
    {
        bldManager = BuildManager.instance;
    }

    public void SelectBasicTower()
    {
        Debug.Log("Standard tower selected...");
        bldManager.SelectTowerToBuild(sTower1);
    }
    public void SelectFastAtackSpeedTower()
    {
        bldManager.SelectTowerToBuild(sTower2);
    }

    public void SlowTowerSelect()
    {
        bldManager.SelectTowerToBuild(sTower3);
    }
}
