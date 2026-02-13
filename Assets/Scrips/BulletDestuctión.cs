using UnityEngine;

public class BulletDestuctión : MonoBehaviour
{
   public  GameObject esplosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Bala") && gameObject.CompareTag("Bala2"))
        {
            Vector3 objectPosition = gameObject.transform.position;
            Destroy(gameObject);
            Instantiate(esplosion, objectPosition, Quaternion.identity);



        }

    }

}

