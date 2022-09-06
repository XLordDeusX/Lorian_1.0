using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed, moveTimer, coolDown;
    public GameObject movableObject;
    public Transform actionDirection;
    private Rigidbody2D rb2D;
    Vector2 movement;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveTimer += Time.deltaTime;

        MovableObject obj = collision.gameObject.GetComponent<MovableObject>();

        if (obj)
        {

        }
    }
    void MovingObject()
    {

    }
}
