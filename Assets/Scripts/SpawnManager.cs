using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static readonly Random rnd = new Random();
    public GameObject platformPrefab;
    public GameObject rockPrefab;
    private Vector2 spawnPosition;
    private float startDelay = 0;
    private float repeatRate = 0.5f;
    
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void Update()
    {

    }

    void SpawnObstacle() {
        int xPos = (rnd.Next(15) - 4);
        int yPos = (rnd.Next(7) - 4);
        spawnPosition = new Vector3(xPos, yPos, 0);
        // while (Physics2D.OverlapAreaAll(new Vector2((xPos-1.5f), (yPos+0.75f)), new Vector2((xPos+1.5f), (yPos-0.75f)), 1) != null)
        // {
        //     xPos = (rnd.Next(15) - 7);
        //     yPos = (rnd.Next(7) - 4);
        // }
        // spawnPosition = new Vector3(xPos, yPos, 0);
        Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);

        xPos = (rnd.Next(15) - 4);
        yPos = (rnd.Next(7) - 4);
        spawnPosition = new Vector3(xPos, yPos, 0);
        Instantiate(rockPrefab, spawnPosition, rockPrefab.transform.rotation);
    }
}
