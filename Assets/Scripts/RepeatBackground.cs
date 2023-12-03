using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{

    private Vector2 startPosition;
    private float repeatPlace;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        repeatPlace = GetComponent<BoxCollider2D>().size.x.CompareTo(12);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPosition.x - repeatPlace)
        {
            transform.position = startPosition;
        }
    }
}
