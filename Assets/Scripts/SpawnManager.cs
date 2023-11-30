using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static readonly Random rnd = new Random();
    public GameObject platformPrefab;
    private Vector2 spawnPosition = new Vector2(25, (rnd.Next(0, 5) -4));
    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle() {
        Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
    }
}
