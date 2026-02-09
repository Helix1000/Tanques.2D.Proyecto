using UnityEngine;

public class RockDestruction : MonoBehaviour
{
    int golpes;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Bala"))
        {
            golpes++;
            Destroy(collision.gameObject);
            if (golpes == 3)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Bala2"))
        {
            golpes++;
            Destroy(collision.gameObject);
            if (golpes == 3)
            {
                Destroy(gameObject);
            }
        }
    }
   
}
