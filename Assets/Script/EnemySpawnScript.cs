﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float SpawnInterval;

    //Spawn area
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerable WaitAndSpawn(float waitTime)
    {
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
            Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
            Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}