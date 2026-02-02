using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting2 : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefab;
    [SerializeField] Transform bulletSpawnPos;

    [SerializeField] float cadencia;
    [SerializeField] float siguienteDisparo;

    InputAction shootAction;

    Vector2 moving;
    private void Awake()
    {

        shootAction = InputSystem.actions.FindAction("Shoot");

    }

    private void Update()
    {
        if (shootAction.WasPressedThisFrame() && Time.time >= siguienteDisparo+cadencia 
            && GameObject.FindGameObjectsWithTag("Bala").Length < 3 && GameObject.FindGameObjectsWithTag("Bala2").Length < 3)
        {
            siguienteDisparo = Time.time;
            Vector2 direction = moving;
            if (direction.sqrMagnitude < 0.01f) direction = -transform.up;
            {
                float angulo = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                Quaternion rotacion = Quaternion.Euler(0, 0, angulo);

                Bullet newBullet = Instantiate(bulletPrefab, bulletSpawnPos.position, rotacion);
                newBullet.Shoot(direction.normalized);

                siguienteDisparo = Time.time + cadencia;
            }
        }
    }
}
