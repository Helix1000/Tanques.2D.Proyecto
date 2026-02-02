using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ScreenWrapping : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get the screen position in pixels
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

        // Get the right side of the screen in world units
        float rightSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x;
        float leftSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).x;

        float topSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y;
        float bottomSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).y;

        // if palyer is moving throught left side of the screen
        if (screenPosition.x <= 0 && rb.linearVelocity.x < 0)
        {
            transform.position= new Vector2 (rightSideOfScreenInWorld, transform.position.y);
        }
        // if palyer is moving throught right side of the screen
        else if (screenPosition.x >= Screen.width && rb.linearVelocity.x > 0)
        {
            transform.position = new Vector2(leftSideOfScreenInWorld, transform.position.y);
        }
        // if palyer is moving throught botton side of the screen
        else if (screenPosition.y >= Screen.height && rb.linearVelocity.y > 0)
        {
            transform.position = new Vector2(transform.position.x, bottomSideOfScreenInWorld);
        }
        // if palyer is moving throught top side of the screen
        else if (screenPosition.y <= 0 && rb.linearVelocity.y < 0)
        {
            transform.position = new Vector2(transform.position.x, topSideOfScreenInWorld);
        }
    } 
}
