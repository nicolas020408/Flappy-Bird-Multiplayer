using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
    #endregion

    Vector2 screenBounds;
    public int[] scores = new int[5];  // Array de pontuação para múltiplos jogadores

    public Vector2 ScreenBounds { get => screenBounds; }

    // Método para ajustar a pontuação de um jogador específico
    public void SetScore(int playerIndex, int score)
    {
        if (playerIndex >= 0 && playerIndex < scores.Length)
        {
            scores[playerIndex] = score;
        }
        else
        {
            Debug.LogWarning("Índice do jogador inválido");
        }
    }

    // Método para exibir as pontuações de todos os jogadores
    public void DisplayAllScores()
    {
        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log("Jogador " + (i + 1) + " Pontuação: " + scores[i]);
        }
    }
}

