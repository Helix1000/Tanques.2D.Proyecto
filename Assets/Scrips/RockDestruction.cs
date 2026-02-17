using UnityEngine;

public class RockDestruction : MonoBehaviour
{
    int golpes;

    public GameObject esplosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Bala"))
        {
            golpes++;
            Vector3 objectPosition = gameObject.transform.position;
            Destroy(collision.gameObject);
            GameObject clone = (GameObject)Instantiate(esplosion, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
           
            if (golpes == 3)
            {

                Destroy(gameObject);
                return;
            }
        }
        if (collision.gameObject.CompareTag("Bala2"))
        {
            golpes++;

            Vector3 objectPosition = gameObject.transform.position;
            Destroy(collision.gameObject);
            GameObject clone = (GameObject)Instantiate(esplosion, transform.position, Quaternion.identity);
            Destroy(clone, 1f);

            if (golpes == 3)
            {
                Destroy(gameObject);
                return;
            }
        }
    }

}
