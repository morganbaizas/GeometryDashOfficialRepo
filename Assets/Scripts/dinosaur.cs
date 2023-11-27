using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinosaur : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private float x = 3f;
    public bool touchingGround = true;


    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && touchingGround)
        {
            playerRb.AddForce(Vector3.up * x, ForceMode2D.Impulse);
        }
    }
}