using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static readonly Random rnd = new Random();
    public GameObject platformPrefab;
    private Vector2 spawnPosition;
    private float startDelay = 0;
    private float repeatRate = 1;
    private float waitTime = 200;

    void Start()
    {
        // InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void FixedUpdate()
    {
        if (waitTime > 0)
        {
            waitTime--;
        }
        else
        {
            InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        }
    }

    void SpawnObstacle() {
        spawnPosition = new Vector3((rnd.Next(15) - 7), (rnd.Next(7) - 4), 0);
        Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
    }
}
