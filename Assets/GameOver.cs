using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0); // Haal de huidige score op uit PlayerPrefs
        int highScore = PlayerPrefs.GetInt("HighScore", 0); // Haal de highscore op uit PlayerPrefs

        // Als de huidige score groter is dan de highscore, stel de huidige score in als de nieuwe highscore
        if (finalScore > highScore)
        {
            highScore = finalScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        scoreText.text = "High Score: " + highScore.ToString();
    }
}