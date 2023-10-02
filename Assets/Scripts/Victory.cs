using TMPro;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0); // Haal de score op uit PlayerPrefs met de juiste sleutel
        scoreText.text = "High Score: " + finalScore.ToString();
    }
}