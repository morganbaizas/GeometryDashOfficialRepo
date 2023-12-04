using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 3;
    private float outOfBounds = -8;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        // if (OnBecameInvisible())

        if(transform.position.x < outOfBounds && (gameObject.CompareTag("platform1") || gameObject.CompareTag("rock1")))
        {
            Debug.Log("destroyes");
            Destroy(gameObject);
        }
        //     Destroy(gameObject);
        
    }
}
