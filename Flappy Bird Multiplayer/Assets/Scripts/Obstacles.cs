using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float speed = 3.5f;
    Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Usar laço para mover múltiplos obstáculos se necessário
        if (transform.position.x < -GameManager.instance.ScreenBounds.x)
        {
            Destroy(gameObject);
        }

        rigidbody2D.velocity = Vector2.left * speed;
    }
}

