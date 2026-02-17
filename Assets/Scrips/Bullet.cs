using System.Linq;
using UnityEngine;
using static UnityEngine.UI.Image;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public GameObject esplosion;

    [SerializeField] float speed = 30f;
    [SerializeField] int baunces = 1;

    private Vector2 direction;
    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
    }
    public void Shoot(Vector2 direction)
    {
        this.direction = direction;

        rb.linearVelocity = this.direction * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        baunces--;
        if (baunces < 0)
        {
            Vector3 objectPosition = gameObject.transform.position;
            Destroy(gameObject);
            GameObject clone = (GameObject)Instantiate(esplosion, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
            return;
        }
        var firstContact = collision.contacts[0];
        Vector2 newVelocity = Vector2.Reflect(direction.normalized, firstContact.normal);
        Shoot(newVelocity.normalized);
    }
    private void FixedUpdate()
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
