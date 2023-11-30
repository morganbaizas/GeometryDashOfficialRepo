using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static readonly Random rnd = new Random();
    public GameObject platformPrefab;
    private Vector2 spawnPosition = new Vector2(25, (rnd.Next(0, 5) -4));

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
