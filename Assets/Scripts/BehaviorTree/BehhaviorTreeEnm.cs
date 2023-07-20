using BehaviorTree;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;

public class BehhaviorTreeEnm : Tree
{
    public UnityEngine.Transform[] btWaypoints;

    
    public static float speed = 5.0f;
    public static float fovRange = 6.0f;

    protected override BTNode SetupTree()
                                         // USED _root instead of
                                        //simple "root" from
                                       //the tutorial
    {
        _root = new TaskPatrol(transform, btWaypoints);
        return
            _root;  
    }
}


