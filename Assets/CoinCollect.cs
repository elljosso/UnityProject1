using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    public static int coin = 0;
    public TextMeshProUGUI coinText;

    public void Start()
    {
        coin = 0;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Coin"))
        {
            coin++;
            coinText.text = "Score: " + coin.ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
        if (coin >= 24) 
        {
            int currentHighScore = PlayerPrefs.GetInt("HighScore", 0); 
            if (coin > currentHighScore) 
            {
                PlayerPrefs.SetInt("HighScore", coin); 
            }
            PlayerPrefs.SetInt("FinalScore", coin);
            SceneManager.LoadScene("Victory"); 
        }
    }

    private void Update()
    {
        if (coin >= 1)
        {
            PlayerPrefs.SetInt("FinalScore", coin);
        }
    }
}   