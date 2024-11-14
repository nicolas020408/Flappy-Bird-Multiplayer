using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float speed = 3.5f;  // Velocidade do obst�culo
    Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObstacle(speed);  // Usando o m�todo com a velocidade

        // Verifica se o obst�culo saiu da tela
        if (transform.position.x < -GameManager.instance.ScreenBounds.x)
        {
            Destroy(gameObject);
        }
    }

    // M�todo para mover o obst�culo
    void MoveObstacle(float speed)
    {
        rigidbody2D.velocity = Vector2.left * speed;
    }

    // M�todo para ajustar a velocidade de todos os obst�culos
    public static void AdjustObstacleSpeed(Obstacles[] obstacles, float newSpeed)
    {
        foreach (Obstacles obstacle in obstacles)
        {
            obstacle.speed = newSpeed;
        }
    }
}




