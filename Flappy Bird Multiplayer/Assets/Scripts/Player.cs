using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    const float jumpForce = 8;
    Rigidbody2D rigidbody2D;
    UIManager managerUI;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        managerUI = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rigidbody2D.velocity = Vector3.zero;
            rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Laço para lidar com múltiplos tipos de colisões
        HandleCollisions(collision.gameObject);
    }

    // Método para tratar diferentes tipos de colisões
    void HandleCollisions(GameObject collidedObject)
    {
        string[] collisionTags = { "Obstacle", "Score" };

        foreach (string tag in collisionTags)
        {
            if (collidedObject.CompareTag(tag))
            {
                if (tag == "Obstacle")
                {
                    GameOver();
                }
                else if (tag == "Score")
                {
                    GameManager.instance.UpdateScore(1); // Aumenta a pontuação
                    managerUI.UpdateScoreText();
                }
            }
        }
    }

    void GameOver()
    {
        if (PlayerPrefs.GetInt("Record") < GameManager.instance.GetScore())
        {
            PlayerPrefs.SetInt("Record", GameManager.instance.GetScore());
        }
        managerUI.GameOver();
    }
}




