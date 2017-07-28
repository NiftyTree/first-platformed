using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject {

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;

    // Use this for initialization

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;
        // Horizontal movement
        move.x = Input.GetAxis ("Horizontal");
        // Player can jump if on ground
        if (Input.GetButtonDown ("Jump") && grounded) {
            velocity.y = jumpTakeOffSpeed;
		// Let's the player cancel their jump mid air
        } else if (Input.GetButtonUp ("Jump")) 
        {
            if (velocity.y > 0) {
                velocity.y = velocity.y * 0.5f;
            }
        }

        targetVelocity = move * maxSpeed;
    }
}