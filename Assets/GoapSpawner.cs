using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoapSpawner : MonoBehaviour
{
    public GameObject goapPrefab;
    public int numberGoapEnemies;

    [SerializeField]
    private float spawningRate;
    [SerializeField]
    private float heightSpawning;
    [SerializeField]
    private float sHeightSpawning;

    void Start()
    {
        StartCoroutine(Spawn());
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
           /* firstWaveSpawned = true;*/
        }

        yield break;//Toggle this to simplify enemies instantiations
    }

    void Update()
    {
        
    }
}
