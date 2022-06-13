using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;

    private Vector2 _moveDirection;

    private void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + _moveDirection * movementSpeed * Time.fixedDeltaTime);
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        _moveDirection = new Vector2(moveX, moveY).normalized;
    }
}
