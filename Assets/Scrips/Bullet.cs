using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] float speed = 30f;

    private Vector2 direction;
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Bullets(Vector2 direction)
    {
        this.direction = direction;

        rb.linearVelocity = this.direction * speed; 
    }
}
