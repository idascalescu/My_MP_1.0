using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class BTSpawner
    : MonoBehaviour

{
    [SerializeField]
    private GameObject enm;

    [SerializeField]
    private GameObject enm2;

    [SerializeField]
    private float spawningRate;

    [SerializeField]
    private Transform SpawningPoint;

    [SerializeField]
    private float heightSpawning;

    [SerializeField]
    private float sHeightSpawning;

   /* private bool firstWaveSpawned;*///FOR SPAWNING WAVES

    void Start()
    {
        StartCoroutine(Spawn());
        
    }

    private void Update()
    {
       /* if (firstWaveSpawned != false)
        {
            StartCoroutine(SpawnWaveTwo());
        }*/
    }

    IEnumerator Spawn()
    {
        Vector3 spawningPos = new Vector3(Random.Range(0.0f, 0.0f),
            heightSpawning, sHeightSpawning);

        for (var i = 0; i < 10; i++)// basic for loop so it will yeild return x 10 times 
        {
            Instantiate(enm, spawningPos, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }
        
        yield break;//Toggle this to simplify enemies instantiations
    }

    IEnumerator SpawnWaveTwo()
    {
        Vector3 spawningPos = new Vector3(Random.Range(0.0f, 0.0f),
            heightSpawning, sHeightSpawning);

        for (var i = 0; i < 10; i++)// basic for loop so it will yeild return x 10 times 
        {
            Instantiate(enm2, spawningPos, Quaternion.identity);
            Debug.Log("WAVE 2 is goin");
            yield return new WaitForSeconds(spawningRate);
        }

        yield break;//Toggle this to simplify enemies instantiations
    }
}
//A TOKEN FOR THIS INFORMATION.
//https://miro.medium.com/v2/resize:fit:1100/format:webp/1*tXP1NrFIg4uJWJ9Db2u1aw.png

