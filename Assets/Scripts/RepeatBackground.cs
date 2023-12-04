using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{

    // private Vector2 startPosition;
    // private float repeatPlace;
    private MeshRenderer _backgroundMeshRenderer;
    private Vector2 _textureOffset = Vector2.zero;
    [SerializeField] private float _speed = 0.15f;
    private float waitTime = 200;

    // Start is called before the first frame update
    void Start()
    {
        // startPosition = transform.position;
        // repeatPlace = (GetComponent<BoxCollider2D>().size.x / 2);
        _backgroundMeshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if (transform.position.x < startPosition.x - repeatPlace)
        // {
        //     transform.position = startPosition;
        // }

        if (waitTime > 0)
        {
            waitTime--;
        }
        else
        {
            _textureOffset.x += _speed * Time.deltaTime;
            _backgroundMeshRenderer.material.mainTextureOffset = _textureOffset;
        }
        
    }
}
