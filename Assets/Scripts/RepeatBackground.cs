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

    // Start is called before the first frame update
    void Start()
    {
        // startPosition = transform.position;
        // repeatPlace = (GetComponent<BoxCollider2D>().size.x / 2);
        _backgroundMeshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (transform.position.x < startPosition.x - repeatPlace)
        // {
        //     transform.position = startPosition;
        // }
        _textureOffset.x += _speed * Time.deltaTime;
        _backgroundMeshRenderer.material.mainTextureOffset = _textureOffset;
    }
}
