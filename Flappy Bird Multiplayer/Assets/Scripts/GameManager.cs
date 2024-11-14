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
    public int score = 0;  // Pontua��o geral

    public Vector2 ScreenBounds { get => screenBounds; }

    // M�todo para atualizar a pontua��o
    public void UpdateScore(int value)
    {
        score += value;
        Debug.Log("Pontua��o Atual: " + score);
    }

    // M�todo para obter a pontua��o
    public int GetScore()
    {
        return score;
    }
}



