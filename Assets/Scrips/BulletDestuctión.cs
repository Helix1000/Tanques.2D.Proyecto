using UnityEngine;

public class BulletDestuctión : MonoBehaviour
{
   public  GameObject esplosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Bala") || gameObject.CompareTag("Bala2"))
        {
            Vector3 objectPosition = gameObject.transform.position;
            collision.gameObject.SetActive(false);
            GameObject clone = (GameObject)Instantiate(esplosion, transform.position, Quaternion.identity);
            Destroy(clone, 1.0f);
            return;


        }

    }
    
}

