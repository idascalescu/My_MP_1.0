using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class BTSpawner
    : MonoBehaviour

{
    [SerializeField]
    private GameObject firstBTPrefab;

    [SerializeField]
    private GameObject secondBTPrefab;

    [SerializeField]
    private GameObject thirdBTPrefab;

    [SerializeField]
    private GameObject fourthBTPrefab;

    [SerializeField]
    private GameObject fifthBTPrefab;

    [SerializeField]
    private float spawningRate;

    [SerializeField]
    private Transform SpawningPoint;

    [SerializeField]
    private float heightSpawning;

    [SerializeField]
    private float sHeightSpawning;

    private Vector3 btOffSet;

    void Start()
    {
        btOffSet = new Vector3(15.0f, 0.0f, 0.0f);
        StartCoroutine(SpawnWaveOne());
    }

    IEnumerator SpawnWaveOne()
    {
        Vector3 spawningPos = new Vector3(Random.Range(0.0f, 0.0f),
            heightSpawning, sHeightSpawning);

        for (var i = 0; i < 10; i++)// basic for loop so it will yeild return x 10 times 
        {
            Instantiate(firstBTPrefab, spawningPos + btOffSet, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }
        
        yield return SpawnWaveTwo();//Toggle this to simplify enemies instantiations
    }

    IEnumerator SpawnWaveTwo()
    {
        Vector3 spawningPos = new Vector3(Random.Range(0.0f, 0.0f),
            heightSpawning, sHeightSpawning);

        for (var i = 0; i < 10; i++)// basic for loop so it will yeild return x 10 times 
        {
            Instantiate(secondBTPrefab, spawningPos + btOffSet, Quaternion.identity);
            
            yield return new WaitForSeconds(spawningRate);
        }

        yield return SpawnWaveThree(); ;//Toggle this to simplify enemies instantiations
    }

    IEnumerator SpawnWaveThree()
    {
        Vector3 spawningPos = new Vector3(Random.Range(0.0f, 0.0f),
            heightSpawning, sHeightSpawning);

        for(var i = 0; i< 10;i++)
        {
            Instantiate(secondBTPrefab, spawningPos + btOffSet, Quaternion.identity);

            yield return new WaitForSeconds(spawningRate);
        }

        yield return SpawnWaveFour();
    }

    IEnumerator SpawnWaveFour()
    {
        Vector3 spawningPos = this.transform.position;

        for (var i = 0; i < 15; i++)// basic for loop so it will yeild return x 15 times 
        {
            Instantiate(fourthBTPrefab, spawningPos + btOffSet, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }
        yield return SpawnWaveFive();
    }

    IEnumerator SpawnWaveFive()
    {
        Vector3 spawningPos = this.transform.position;

        for (var i = 0; i < 18; i++)// basic for loop so it will yeild return x 18 times 
        {
            Instantiate(fifthBTPrefab, spawningPos + btOffSet, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }
        yield break;
    }
}
//A TOKEN FOR THIS INFORMATION.
//https://miro.medium.com/v2/resize:fit:1100/format:webp/1*tXP1NrFIg4uJWJ9Db2u1aw.png

