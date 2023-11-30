using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    private float speed = 10;



    void Start()
    {
        
    }



    void Update()
    {
       transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
