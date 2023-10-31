using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float moveSpeed = 10f;
    private Vector3 startingPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startingPos = transform.position;
    }

    private void FixedUpdate()
    {
        if(transform.position.z < startingPos.z)
        {
            rb.AddForce(0f, 0f, 20f);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(moveSpeed * Time.deltaTime, 0f, 0f);
            rb.velocity = new Vector3(moveSpeed,rb.velocity.y,rb.velocity.z);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0);
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, rb.velocity.z);
        }
    }
}
