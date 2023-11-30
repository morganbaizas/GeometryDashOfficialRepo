using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinosaur : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private float x = 10f;
    public bool touchingGround = true;


    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && touchingGround)
        {
            playerRb.AddForce(Vector2.up * x, ForceMode2D.Impulse);
            touchingGround = false;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        touchingGround = true;
    }
}