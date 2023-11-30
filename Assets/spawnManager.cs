using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject platformPrefab;
    private Vector2 spawnPos = new Vector2(25, 0);
    private float startDelay = 2;
    private float repeatRate = 2;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(platformPrefab, spawnPos, platformPrefab.transform.rotation);
    }
}
