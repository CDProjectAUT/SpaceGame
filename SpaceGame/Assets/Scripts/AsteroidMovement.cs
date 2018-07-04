using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody rigidbodyAsteroid;
    Vector3 movement;

    void Awake()
    {
        rigidbodyAsteroid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        movement.Set(0f, 0f, -speed);

        movement = movement.normalized * speed * Time.deltaTime;
        rigidbodyAsteroid.MovePosition(transform.position + movement);
    }
}
