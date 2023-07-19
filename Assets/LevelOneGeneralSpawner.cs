using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LevelOneGeneralSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemyPrefabs;

    [SerializeField]
    private int baseEnemies = 10;
    [SerializeField]
    private float enemiesPerSecond = 0.9f;
    [SerializeField]
    private float timeBetweenWaves = 5.0f;
    [SerializeField]
    private float difficultyScallingFactor = 0.75f;

    public static UnityEvent onEnemyDestroy;

    private int currentWave = 1;
    private float timeSinceLastSpawn;
    private int aliveEnemies;
    private int enemiesLeftToSpawn;
    private bool isSpawnining = false;

    private void Awake()
    {
        onEnemyDestroy.AddListener(EnemyDestroyed);//EnemyDestroyed must pe invoked into the enemy scrips
    }

    private void Start()
    {
        StartCoroutine(StartWave());
    }

    private void Update()
    {
        if(!isSpawnining) { return; }

        timeSinceLastSpawn += Time.deltaTime;

        if(timeSinceLastSpawn >=(3 /  enemiesPerSecond) && enemiesLeftToSpawn > 0)
        {
            SpawnEnemy();
            enemiesLeftToSpawn--;
            aliveEnemies++;
            timeSinceLastSpawn = 0.0f;
        }

        if(aliveEnemies == 0 && enemiesLeftToSpawn == 0) { EndWave(); }
    }

    private void EnemyDestroyed()
    {
        aliveEnemies--;
    }    

    private IEnumerator StartWave()
    {
        yield return new WaitForSeconds(timeBetweenWaves);
        isSpawnining = true;    
        enemiesLeftToSpawn = EnemiesPerWave();
    }

    private void EndWave()
    {
        isSpawnining = false;
        timeSinceLastSpawn = 0.0f;
        currentWave++;
        StartCoroutine(StartWave());
    }

    private void SpawnEnemy()
    {
        GameObject prefabToSpawn = enemyPrefabs[0];
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
    }

    private int EnemiesPerWave()
    {
        return Mathf.RoundToInt(baseEnemies *Mathf.Pow(currentWave, difficultyScallingFactor)); 
    }
}
// https://www.youtube.com/watch?v=5j8A79-YUo0
