
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if(instance != null) 
        {
            Debug.Log("More than one BuildManager in the scene");
        }
        instance = this;//This BuildManager will be put in this instance variable
                        //This will be a refference for BuildMngr
    }

    [SerializeField]
    public GameObject stdTowerPrefab;
    [SerializeField]
    public GameObject anotherTowerPrefab;

    private TowerBluePrint towerToBuild;

    public bool CanBuild { get { return towerToBuild != null; } }
    public bool PlayerHasMoney { get { return PStats.money >= towerToBuild.cost; } }

    public void BuiltTowerOn(NodeScript node)
    {
        if(PStats.money < towerToBuild.cost)
        {
            Debug.Log("Not enough money to build yo");
            return;
        }

        PStats.money -= towerToBuild.cost;

        GameObject tower = Instantiate(towerToBuild.tPrefab, node.GetBuildPos(), Quaternion.identity);
        GameObject tower2 = Instantiate(towerToBuild.tPrefab2, node.GetBuildPos(), Quaternion.identity);
        node.tower = tower;

        Debug.Log("Tower built ! Money left:" + PStats.money);
    }

    public void SelectTowerToBuild(TowerBluePrint tower)
    {
        towerToBuild = tower; //MUST BE FIXED TOMORROW THE LATEST !!! 18/07
    }
}
