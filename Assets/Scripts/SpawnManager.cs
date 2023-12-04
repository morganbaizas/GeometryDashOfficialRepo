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
    private float repeatRate = 2;

    // if (platformPrefab)
    // {
    //     random = (rnd.Next(0, 5)) - 4;
    //     spawnPosition = new Vector2(25, random);
    // } else
    // {
    //     random = (rnd.Next(1, 5) - 4);
    //     spawnPosition = new Vector2(25, random);
    // }

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
        Instantiate(platformPrefab, new Vector2(25, (rnd.Next(1, 5) - 4)), platformPrefab.transform.rotation);
    }
}
