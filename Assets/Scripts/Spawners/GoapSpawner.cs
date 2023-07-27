using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoapSpawner : UnityEngine.MonoBehaviour
{
    public GameObject firstGoapPrefab;
    public GameObject secondGoapPrefab;
    public GameObject thirdGoapPrefab;
    public GameObject fourthGoapPrefab;
    public GameObject fifthGoapPrefab;

    public int numberGoapEnemies;

    [SerializeField]
    private float spawningRate;
    [SerializeField]
    private float heightSpawning;
    [SerializeField]
    private float sHeightSpawning;

    private void Awake()
    {
        StartCoroutine(SpawnWaveOne());
    }

    IEnumerator SpawnWaveOne()
    {
        Vector3 spawningPos = this.transform.position;

        for (var i = 0; i < 10; i++)// basic for loop so it will yeild return x 10 times
        {
            Instantiate(firstGoapPrefab, spawningPos, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
            numberGoapEnemies ++;
        }
        yield return SpawnWaveTwo();//Toggle this to simplify enemies instantiations
    }

    IEnumerator SpawnWaveTwo()
    {
        Vector3 spawningPos = this.transform.position;

        for (var i = 0; i < 10; i++)// basic for loop so it will yeild return x 10 times 
        {
            Instantiate(secondGoapPrefab, spawningPos, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }
        yield return SpawnWaveThree();
    }

    IEnumerator SpawnWaveThree()
    {
        Vector3 spawningPos = this.transform.position;

        for (var i = 0; i < 10; i++)// basic for loop so it will yeild return x 10 times 
        {
            Instantiate(thirdGoapPrefab, spawningPos, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }
        yield return SpawnWaveFour();
    }

    IEnumerator SpawnWaveFour()
    {
        Vector3 spawningPos = this.transform.position;

        for (var i = 0; i < 15; i++)// basic for loop so it will yeild return x 15 times 
        {
            Instantiate(fourthGoapPrefab, spawningPos, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }
        yield return SpawnWaveFive();
    }

    IEnumerator SpawnWaveFive()
    {
        Vector3 spawningPos = this.transform.position;

        for (var i = 0; i < 18; i++)// basic for loop so it will yeild return x 18 times 
        {
            Instantiate(fifthGoapPrefab, spawningPos, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }
        yield break;
    }
}
//https://stackoverflow.com/questions/50424041/wait-until-coroutine-finishes-before-starting-another-coroutine-unity-c#:~:text=1%20Answer,-Sorted%20by%3A&text=If%20you%20want%20to%20wait,the%20rest%20of%20the%20code.
// This was the way I made the waves to work . It's not the best but it works 
