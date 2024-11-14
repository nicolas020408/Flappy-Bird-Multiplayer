using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText, finalScoreText, recordText;
    [SerializeField] GameObject gameOverWindow;

    public void UpdateScoreText()
    {
        // Usando um laço para atualizar textos
        TextMeshProUGUI[] texts = { scoreText, finalScoreText, recordText };
        foreach (TextMeshProUGUI text in texts)
        {
            if (text == scoreText)
            {
                text.text = GameManager.instance.Score.ToString();
            }
            else if (text == finalScoreText)
            {
                text.text = GameManager.instance.Score.ToString();
            }
            else if (text == recordText)
            {
                text.text = PlayerPrefs.GetInt("Record").ToString();
            }
        }
    }

    public void GameOver()
    {
        finalScoreText.text = GameManager.instance.Score.ToString();
        recordText.text = PlayerPrefs.GetInt("Record").ToString();
        gameOverWindow.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

