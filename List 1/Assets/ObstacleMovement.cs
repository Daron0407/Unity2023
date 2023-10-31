using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 30f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.localScale = new Vector3(Random.Range(.1f, 3f), Random.Range(.1f, 3f), Random.Range(.1f, 3f));
    }
    private void FixedUpdate()
    {
        rb.AddForce(0f, 0f, -speed);
        if(transform.position.z < -100f || transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
