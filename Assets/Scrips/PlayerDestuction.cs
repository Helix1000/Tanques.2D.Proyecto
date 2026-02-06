using UnityEngine;

public class PlayerDestuction : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Bala"))
        {

            GameManager.Instance.GanarRonda();

            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Bala2"))
        {

            GameManager.Instance.GanarRonda2();

            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }

}
