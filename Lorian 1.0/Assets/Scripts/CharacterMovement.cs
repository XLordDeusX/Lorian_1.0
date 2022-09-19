using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D myRigidBody2D;
    private Animator anim;
    Vector2 movement;

    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement = Vector2.zero;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;

        AnimationUpdate();
    }

    private void FixedUpdate()
    {
        myRigidBody2D.MovePosition(myRigidBody2D.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void AnimationUpdate()
    {
        if (movement != Vector2.zero)
        {
            anim.SetFloat("moveX", movement.x);
            anim.SetFloat("moveY", movement.y);
            anim.SetBool("moving", true);
        }
        else
        {
            anim.SetBool("moving", false);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        moveTimer += Time.deltaTime;

        MovableObject obj = collision.gameObject.GetComponent<MovableObject>();

        if (obj)
        {

        }
    }*/
}
