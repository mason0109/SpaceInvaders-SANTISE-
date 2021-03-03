using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float runSpeed;

    private Rigidbody2D rigidbody;
    private Vector2 myVelocity;
    private Vector2 currentInputDirection;

    //to keep the player in bounds?
    public float maxBound, minBound;

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    } 

    public void Move(Vector2 direction)
    {
        myVelocity = rigidbody.velocity;
        myVelocity.x = direction.x * runSpeed;
        rigidbody.velocity = myVelocity;
    }

    public void onMove(InputAction.CallbackContext input)
    {
        Move(input.ReadValue<Vector2>());
    }
}
