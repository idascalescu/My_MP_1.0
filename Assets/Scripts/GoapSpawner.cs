using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoapSpawner : MonoBehaviour
{
    public GameObject goapPrefab;
    public GameObject secondGoapPrefab;
    public int numberGoapEnemies;

    [SerializeField]
    private float spawningRate;
    [SerializeField]
    private float heightSpawning;
    [SerializeField]
    private float sHeightSpawning;

    public bool firstWaveSpawned;

    private void Awake()
    {
        StartCoroutine(Spawn());
    }

    void Start()
    {
       
    }

    /*  private void SpawnGoap()
      {
          Instantiate(goapPrefab, this.transform.position, Quaternion.identity);
          Invoke("SpawnGoap", Random.Range(2, 10));
      }*/

    IEnumerator Spawn()
    {
        Vector3 spawningPos = this.transform.position;
         
        for (var i = 0; i < 10; i++)// basic for loop so it will yeild return x 10 times 
        {
            Instantiate(goapPrefab, spawningPos, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
            numberGoapEnemies = 10;
        }

        yield break;//Toggle this to simplify enemies instantiations
    }

    IEnumerator SpawnWaveTwo()
    {
        Vector3 spawningPos = this.transform.position;

        for (var i = 0; i < 10; i++)// basic for loop so it will yeild return x 10 times 
        {
            Instantiate(secondGoapPrefab, spawningPos, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }

        yield break;
    }

    /*void Update()
    {
        if(firstWaveSpawned == true)
        {
            SpawnWaveTwo();
        }
    }*/
}
