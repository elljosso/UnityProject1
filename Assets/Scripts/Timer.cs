using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float totalTime = 120f;
    private float currentTime;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText; // Voeg een referentie toe naar het score TextMeshProUGUI-object

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        timeText.text = "Timer: " + currentTime.ToString("F0"); // Toon de timerwaarde met twee decimalen

        if (currentTime <= 0f)
        {
            // De tijd is om, sla de score op in PlayerPrefs en schakel over naar de "GameOver" -scene
            PlayerPrefs.SetInt("FinalScore", CoinCollect.coin); // Gebruik CoinCollect.coin zonder problemen
            SceneManager.LoadScene("GameOver");
        }
    }
}