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
    public int score = 0;  // Pontuação geral

    public Vector2 ScreenBounds { get => screenBounds; }

    // Método para atualizar a pontuação
    public void UpdateScore(int value)
    {
        score += value;
        Debug.Log("Pontuação Atual: " + score);
    }

    // Método para obter a pontuação
    public int GetScore()
    {
        return score;
    }
}



