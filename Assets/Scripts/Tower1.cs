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

    [Header("Atributes")]

    public float towerRange = 21.0f;
    public float fireRate = 10.0f;
    private float fireCountdown = 0.0f;

    [Header("Unity Setup")]

    public string enemyTag = "Enemy";
    public Transform partToRotate;
    public float turningSpeed = 9.0f;

    public GameObject bulletPrefab;
    public Transform firePoint;
    
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0.0f, 0.5f);
        //Invoke that method = last variable is seconds
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
        partToRotate.rotation = Quaternion.Euler(0.0f, qRotation.y - 
            towerOffsetRot, 0.0f);

        if(fireCountdown <= 0.0f)
        {
            Shoot();
            fireCountdown = 1.0f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject bulletGO = (GameObject) Instantiate
            (bulletPrefab, 
            firePoint.position, firePoint.rotation);

        FibresMisles fbrBullet = bulletGO.GetComponent
            <FibresMisles>();
        if (fbrBullet != null)
        {
            fbrBullet.Seek(target);
        } 
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, towerRange);
    }  
}
