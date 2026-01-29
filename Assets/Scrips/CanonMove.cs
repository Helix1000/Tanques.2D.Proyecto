using UnityEngine;
using UnityEngine.InputSystem;

public class CanonMove : MonoBehaviour
{
    public float turnSpeed;

    public float rotateSpeed;

    InputAction RotateAction;

    InputAction turnAction;

    

    private void Awake()
    {
        turnAction = InputSystem.actions.FindAction("Turn");
       RotateAction = InputSystem.actions.FindAction("Rotate");

    }

    private void FixedUpdate()
    {
        Vector2 turnInput = turnAction.ReadValue<Vector2>();
        transform.Rotate(0, 0, turnInput.x * turnSpeed * Time.fixedDeltaTime);

        Vector2 rotateInput = RotateAction.ReadValue<Vector2>();
        transform.Rotate(0,0, rotateInput.x * rotateSpeed * Time.fixedDeltaTime);

       
    }
}
