using UnityEngine;

public class PlayerJoin : MonoBehaviour
{
    public Transform spawnPoint1, spawnPoint2;
    public GameObject Player1, Player2;

    private void Awake()
    {
        Instantiate(Player1, spawnPoint1.position, spawnPoint1.rotation);
        Instantiate(Player2, spawnPoint2.position, spawnPoint2.rotation);
    }
}
