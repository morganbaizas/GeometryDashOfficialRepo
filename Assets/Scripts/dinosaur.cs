using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dinosaur : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private float x = 10f;
    private float speed = 3f;
    public bool touchingGround = true;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space) && touchingGround)
        {
            playerRb.AddForce(Vector2.up * x, ForceMode2D.Impulse);
            touchingGround = false;
        }

        if (transform.position.y < -4.5 || transform.position.x < -8.75)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("DiedScene");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        touchingGround = true;
    }
}