using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorthSpawn : MonoBehaviour
{
    public GameObject[] zombiePrefabs;
    private float spawnRangeX = 1.5f;
    private float spawnPosZ = 15;
    private float spanwPosY = 1.25f;
    private float startDelay = 2;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnZombie", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnZombie()
    {
        int ZombieIndex = Random.Range(0, zombiePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spanwPosY, spawnPosZ);
        Instantiate(zombiePrefabs[ZombieIndex], spawnPos, zombiePrefabs[ZombieIndex].transform.rotation);
    }
}
