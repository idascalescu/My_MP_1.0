using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BTSpawner
    : MonoBehaviour

{
    [SerializeField]
    private GameObject enm;

    [SerializeField]
    private float spawningRate;

    [SerializeField]
    private Transform SpawningPoint;

    [SerializeField]
    private float heightSpawning;

    [SerializeField]
    private float sHeightSpawning;

    void Start()
    {    
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        Vector3 spawningPos = new Vector3(Random.Range(0.0f, 0.0f),
            heightSpawning, sHeightSpawning);

        for (var i = 0; i < 9; i++)
        {
            Instantiate(enm, spawningPos, Quaternion.identity);
            yield return new WaitForSeconds(spawningRate);
        }

        yield break;   //Toggle this to simplify enemies instantiations
    }
}
//A TOKEN TO MY IONCOMPETENCE !!!
//https://miro.medium.com/v2/resize:fit:1100/format:webp/1*tXP1NrFIg4uJWJ9Db2u1aw.png

