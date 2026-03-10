using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] AudioSource fuenteDeAudio;
    [SerializeField] AudioClip sonidoHit;
    [SerializeField] AudioClip sonidoExplosion;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject esplosionPrefab; 

    [SerializeField] float speed = 30f;
    [SerializeField] int bounces = 2; 

    private Vector2 direction;

    private void Awake()
    {
         rb = GetComponent<Rigidbody2D>();

    }

    public void Shoot(Vector2 direction)
    {
        this.direction = direction.normalized;
        rb.linearVelocity = this.direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bounces--;

        if (bounces <= 0)
        {
            Explode();
        }
        else
        {
            
            fuenteDeAudio.PlayOneShot(sonidoHit);

           
            var firstContact = collision.contacts[0];
            Vector2 newVelocity = Vector2.Reflect(direction, firstContact.normal);
            Shoot(newVelocity);
        }
    }

    private void Explode()
    {
      
        GameObject clone = Instantiate(esplosionPrefab, transform.position, Quaternion.identity);
        Destroy(clone, 1.0f);

        
        AudioSource.PlayClipAtPoint(sonidoExplosion, transform.position, 5.0f);

        
        gameObject.SetActive(false);
      
    }

    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}