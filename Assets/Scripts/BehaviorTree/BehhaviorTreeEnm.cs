using BehaviorTree;
using System.Runtime.InteropServices.WindowsRuntime;

public class BehhaviorTreeEnm : Tree
{
    public UnityEngine.Transform[] btWaypoints;

    public static float speed = 1.0f;
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


