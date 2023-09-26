using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0); // Haal de score op uit PlayerPrefs met de juiste sleutel
        scoreText.text = "Score: " + finalScore.ToString();
    }
}