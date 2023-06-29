using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1 : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float towerOffsetRot;

    public float towerRange = 21.0f;
   
    public string enemyTag = "Enemy";
    public Transform partToRotate;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0.0f, 0.5f);//Invoke that method = last variable is seconds
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag
            (enemyTag);
        Debug.Log("Target found");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position,
                enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= towerRange)
        {
            target = nearestEnemy.transform;
        }
    }

    void Update()
    {
        if (target == null)
            return;
        //TOWER ROT
        Vector3 oneDirection = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(oneDirection);
        Vector3 qRotation = lookRotation.eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0.0f, qRotation.y - towerOffsetRot, 0.0f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, towerRange);
    }

   
}
