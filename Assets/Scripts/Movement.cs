using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int _speed;
    private Rigidbody2D _rb;
    private Vector2 _direction;
    [SerializeField] private FOV _fov;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _fov.SetOrigin(transform.position);
    }

    void FixedUpdate()
    {
        _rb.MovePosition((Vector2)transform.position + (_speed * Time.deltaTime * _direction));
    }
}
