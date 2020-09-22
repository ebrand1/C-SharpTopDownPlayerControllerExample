using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This variable is to easily adjust how quickly the character moves
    public float moveSpeed = 5f;
    //This variable allows for getting input in Update, but perform movement in FixedUpdate
    public Vector2 movementVector;

    //This references the rigidbody, where movement will be applied
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");
    }

    // Fixed update is called 50 times a second by default
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementVector * moveSpeed * Time.fixedDeltaTime);
    }
}
