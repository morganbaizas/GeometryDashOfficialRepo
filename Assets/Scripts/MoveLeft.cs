using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 15;
    private float waitTime = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (waitTime > 0)
        {
            waitTime--;
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    }

}
