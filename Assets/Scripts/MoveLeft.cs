using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 3;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        // if (OnBecameInvisible())
        //     Destroy(gameObject);
        
    }
}
