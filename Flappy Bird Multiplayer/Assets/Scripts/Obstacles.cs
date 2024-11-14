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
        // Usar la�o para mover m�ltiplos obst�culos se necess�rio
        if (transform.position.x < -GameManager.instance.ScreenBounds.x)
        {
            Destroy(gameObject);
        }

        rigidbody2D.velocity = Vector2.left * speed;
    }
}

