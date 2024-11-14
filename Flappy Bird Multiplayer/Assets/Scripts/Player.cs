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
        // Verificar se o jogador apertou qualquer tecla de "pulo"
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rigidbody2D.velocity = Vector3.zero;
            rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Usando um la�o para verificar m�ltiplos tipos de colis�es
        string[] tags = { "Obstacle", "Score" };
        foreach (string tag in tags)
        {
            if (collision.gameObject.tag == tag)
            {
                if (tag == "Obstacle")
                {
                    GameOver();
                }
                else if (tag == "Score")
                {
                    GameManager.instance.Score++;
                    managerUI.UpdateScoreText();
                }
            }
        }
    }

    void GameOver()
    {
        if (PlayerPrefs.GetInt("Record") < GameManager.instance.Score)
        {
            PlayerPrefs.SetInt("Record", GameManager.instance.Score);
        }
        managerUI.GameOver();
    }
}

