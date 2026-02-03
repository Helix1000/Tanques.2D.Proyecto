using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefab;
    [SerializeField] Transform bulletSpawnPos;

    public float turnSpeed;
    public float moveSpeed;
    public float rotateSpeed;
    public float giroSpeed;

    [SerializeField] float cadencia;
    [SerializeField] float siguienteDisparo;

    bool shootAction = false;

    Vector2 moving;

    //InputAction turnAction;
    //InputAction moveAction;

    public GameObject ancla;

    private Vector2 GiroAction;
    private Vector2 turnAction;
    private Vector2 moveAction;
    private Vector2 rotateAction;

    Rigidbody2D rb2D;
   
    private void Awake()
    {
       // turnAction = InputSystem.actions.FindAction("Turn");
       // moveAction = InputSystem.actions.FindAction("Move");
        rb2D = GetComponent<Rigidbody2D>();
    }
    public void OnMove(InputValue value)
    {
        moveAction = value.Get<Vector2>();
    }
    public void OnTurn(InputValue value)
    {
        turnAction = value.Get<Vector2>();
    }
    public void OnRotate(InputValue value)
    {
        rotateAction = value.Get<Vector2>();
    }
    public void OnGiro(InputValue value)
    {
        GiroAction = value.Get<Vector2>();
    }

    public void OnShoot(InputValue value)
    {
        // Si usas "WasPressedThisFrame", solo detectamos el inicio
        shootAction = value.isPressed;
    }

    private void FixedUpdate()
    {
        //Vector2 turnInput = turnAction.ReadValue<Vector2>();
        rb2D.rotation = rb2D.rotation + (turnAction.x * turnSpeed * Time.fixedDeltaTime);

        //Vector2 moveInput = moveAction.ReadValue<Vector2>();
        rb2D.linearVelocity = transform.up * moveAction.y * moveSpeed * Time.fixedDeltaTime;

        if( ancla != null )
        {
            //Vector2 turnInput = turnAction.ReadValue<Vector2>();
            ancla.transform.Rotate(0, 0, GiroAction.x * giroSpeed * Time.fixedDeltaTime);

            //Vector2 rotateInput = RotateAction.ReadValue<Vector2>();
            ancla.transform.Rotate(0, 0, rotateAction.x * rotateSpeed * Time.fixedDeltaTime);
        }
     
    }
    private void Update()
    {
        // Agregamos la condición de tiempo y límite de balas
        if (shootAction && Time.time >= siguienteDisparo)
        {
            if (GameObject.FindGameObjectsWithTag("Bala").Length < 3 
                && GameObject.FindGameObjectsWithTag("Bala2").Length < 3)
            {
                Disparar();
                siguienteDisparo = Time.time + cadencia;
            }

            // Si quieres que no sea ráfaga automática, apaga el trigger
            shootAction = false;
        }
    }

    void Disparar()
    {
        Vector2 direccionDisparo = ancla != null ? ancla.transform.up : transform.up;

        float angulo = Mathf.Atan2(direccionDisparo.y, direccionDisparo.x) * Mathf.Rad2Deg - 90f;
        Quaternion rotacion = Quaternion.Euler(0, 0, angulo);

        Bullet newBullet = Instantiate(bulletPrefab, bulletSpawnPos.position, rotacion);

        // Le pasamos la dirección y una referencia a este script para avisar cuando se destruya
        newBullet.Shoot(direccionDisparo.normalized);
    }
}