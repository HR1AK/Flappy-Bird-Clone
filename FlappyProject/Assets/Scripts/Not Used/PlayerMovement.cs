using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocity = 0.5f;
    [SerializeField] private float rotationSpeed = 10f;

    private Rigidbody2D rb;
    private Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
        
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MyGameManager.instance.GameOver();
    }
}
