
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

    [SerializeField]
    public GameObject towerToBuild;

    public GameObject GetTowerToBuild()
    {
        return towerToBuild;
    }

    public void SetTowerToBuild(GameObject tower)
    {
        towerToBuild = tower;
    }
}
