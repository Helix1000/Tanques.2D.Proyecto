using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefab;
    [SerializeField] Transform bulletSpawnPos;
   

    InputAction shootAction;

    Vector2 moving;
    private void Awake()
    {

        shootAction = InputSystem.actions.FindAction("Shoot");

    }

    private void Update()
    {
        if (shootAction.WasPressedThisFrame())
        {
           
            Vector2 direction = moving;
            if (direction.sqrMagnitude < 0.01f) direction = -transform.up;
            {
                float angulo = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                Quaternion rotacion = Quaternion.Euler(0, 0, angulo);

                Bullet newBullet = Instantiate(bulletPrefab, bulletSpawnPos.position, rotacion);
                newBullet.Shoot(direction.normalized);

            }
        }
    }
}
