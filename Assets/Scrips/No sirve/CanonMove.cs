using UnityEngine;
using UnityEngine.InputSystem;

public class CanonMove : MonoBehaviour
{
    public float turnSpeed;

    public float rotateSpeed;

   // InputAction RotateAction;

    //InputAction turnAction;

    private Vector2 turnAction;
    private Vector2 rotateAction;

    private void Awake()
    {
       //turnAction = InputSystem.actions.FindAction("Turn");
       //RotateAction = InputSystem.actions.FindAction("Rotate");

    }
    public void OnRotate(InputValue value)
    {
        rotateAction = value.Get<Vector2>();
    }
    public void OnTurn(InputValue value)
    {
        turnAction = value.Get<Vector2>();
    }
    
    private void FixedUpdate()
    {
        //Vector2 turnInput = turnAction.ReadValue<Vector2>();
        transform.Rotate(0, 0, turnAction.x * turnSpeed * Time.fixedDeltaTime);

        //Vector2 rotateInput = RotateAction.ReadValue<Vector2>();
        transform.Rotate(0,0, rotateAction.x * rotateSpeed * Time.fixedDeltaTime);

       
    }
}
