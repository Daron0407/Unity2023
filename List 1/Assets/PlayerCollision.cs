using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            DisableMovement(1f);
            movement.rb.AddForce(0f, 0f, -10f);
        }
    }

    private void DisableMovement(float time)
    {
        movement.enabled = false;
        Invoke("EnableMovement", time);
    }

    private void EnableMovement()
    {
        movement.rb.velocity = Vector3.zero;
        movement.enabled = true;
    }
}
