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
    public int[] scores = new int[5];  // Array de pontua��o para m�ltiplos jogadores

    public Vector2 ScreenBounds { get => screenBounds; }

    // M�todo para ajustar a pontua��o de um jogador espec�fico
    public void SetScore(int playerIndex, int score)
    {
        if (playerIndex >= 0 && playerIndex < scores.Length)
        {
            scores[playerIndex] = score;
        }
        else
        {
            Debug.LogWarning("�ndice do jogador inv�lido");
        }
    }

    // M�todo para exibir as pontua��es de todos os jogadores
    public void DisplayAllScores()
    {
        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log("Jogador " + (i + 1) + " Pontua��o: " + scores[i]);
        }
    }
}

