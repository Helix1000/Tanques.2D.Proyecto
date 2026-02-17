using UnityEngine;

public class PlayerDestuction : MonoBehaviour
{
    public GameObject esplosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Bala")&& gameObject.CompareTag("Player2"))
        {

            GameManager.Instance.GanarRonda();

            Destroy(collision.gameObject);

            Vector3 objectPosition = gameObject.transform.position;
            Destroy(gameObject);
            GameObject clone = (GameObject)Instantiate(esplosion, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
            return;
        }
        if (collision.gameObject.CompareTag("Bala2")&& gameObject.CompareTag("Player2"))
        {

            GameManager.Instance.GanarRonda();

            Destroy(collision.gameObject);

            Vector3 objectPosition = gameObject.transform.position;
            Destroy(gameObject);
            GameObject clone = (GameObject)Instantiate(esplosion, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
            return;
        }

        //

        if (collision.gameObject.CompareTag("Bala2") && gameObject.CompareTag("Player"))
        {

            GameManager.Instance.GanarRonda2();

            Destroy(collision.gameObject);

            Vector3 objectPosition = gameObject.transform.position;
            Destroy(gameObject);
            GameObject clone = (GameObject)Instantiate(esplosion, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
            return;
        }
        if (collision.gameObject.CompareTag("Bala") && gameObject.CompareTag("Player"))
        {

            GameManager.Instance.GanarRonda2();

            Destroy(collision.gameObject);

            Vector3 objectPosition = gameObject.transform.position;
            Destroy(gameObject);
            GameObject clone = (GameObject)Instantiate(esplosion, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
            return;
        }
    }

}
