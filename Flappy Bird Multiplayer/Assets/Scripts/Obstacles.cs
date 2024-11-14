using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float speed = 3.5f;  // Velocidade do obstáculo
    Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObstacle(speed);  // Usando o método com a velocidade

        // Verifica se o obstáculo saiu da tela
        if (transform.position.x < -GameManager.instance.ScreenBounds.x)
        {
            Destroy(gameObject);
        }
    }

    // Método para mover o obstáculo
    void MoveObstacle(float speed)
    {
        rigidbody2D.velocity = Vector2.left * speed;
    }

    // Método para ajustar a velocidade de todos os obstáculos
    public static void AdjustObstacleSpeed(Obstacles[] obstacles, float newSpeed)
    {
        foreach (Obstacles obstacle in obstacles)
        {
            obstacle.speed = newSpeed;
        }
    }
}




