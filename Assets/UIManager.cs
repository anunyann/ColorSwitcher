using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    public TextMeshProUGUI resultText;

    private int score = 0;
    public int totalGates = 100;

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score >= totalGates)
        {
            ShowResult("You Win!");
        }
    }

    public void ShowResult(string message)
    {
        resultText.text = message;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}