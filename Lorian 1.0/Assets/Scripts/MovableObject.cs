using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    public float moveSpeed, moveTimer, coolDown;
    private Rigidbody2D objectRB;
    Vector2 objectMovement;
    void Start()
    {
        objectRB = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        moveTimer += Time.deltaTime;
    }
    void FixedUpdate()
    {
        
        objectRB.MovePosition(objectRB.position + objectMovement * moveSpeed * Time.fixedDeltaTime);
    }
}
