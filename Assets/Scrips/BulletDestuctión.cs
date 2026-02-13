using UnityEngine;

public class BulletDestuctión : MonoBehaviour
{
   public  GameObject esplosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Instantiate(esplosion);
        Destroy(esplosion, 1f);
    }

}
