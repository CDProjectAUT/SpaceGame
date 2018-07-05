using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float smoothing;
    public float tilt;
    public float xMin, xMax, zMin, zMax;
    Rigidbody rb;
   

    void Start()
    {
      
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moverHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moverHorizontal, 0f, moveVertical);

        rb.velocity = movement * speed*smoothing;

        rb.position = new Vector3
       (
           Mathf.Clamp(rb.position.x, xMin, xMax),
           0.0f,
           Mathf.Clamp(rb.position.z, zMin, zMax)
       );


        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
       
    }



}
