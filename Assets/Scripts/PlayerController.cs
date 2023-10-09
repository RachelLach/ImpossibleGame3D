using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    
    public float speed = 4f; // Field

    public float jumpForce = 300;

    public float jumpSpin = 2;

    private void FixedUpdate()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        if (rigidBody.velocity.y < -.1f)
        {
            rigidBody.AddForce(0, -1, 0);
        }

        rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, z: speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Jump();
        }

    }

    private void Jump()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        rigidBody.AddForce(0, jumpForce, 0);
        rigidBody.angularVelocity = new Vector3(jumpSpin, 0, 0);
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}