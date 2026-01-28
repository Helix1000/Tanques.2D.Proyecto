using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed;
    public float moveSpeed;

    InputAction turnAction;
    InputAction moveAction;

    Rigidbody2D rb2D;
   
    private void Awake()
    {
        turnAction = InputSystem.actions.FindAction("Turn");
        moveAction = InputSystem.actions.FindAction("Move");
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 turnInput = turnAction.ReadValue<Vector2>();
        rb2D.rotation = rb2D.rotation + (turnInput.x * turnSpeed * Time.fixedDeltaTime);

        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        rb2D.linearVelocity = transform.up * moveInput.y * moveSpeed * Time.fixedDeltaTime;
    }
}