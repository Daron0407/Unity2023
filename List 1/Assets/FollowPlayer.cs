using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0f,3f,-8f);
   
    void Update()
    {
        transform.position = player.position + offset;
    }
}
