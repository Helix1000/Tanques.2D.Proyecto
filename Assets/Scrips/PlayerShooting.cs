using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletSpawnPos;

    

    InputAction shootAction;
    private void Awake()
    {
        shootAction = InputSystem.actions.FindAction("Shoot");
    }

    private void Update()
    {
        if (shootAction.WasPressedThisFrame())
        {
            //Vector2 direction = 
        }
    }
}
