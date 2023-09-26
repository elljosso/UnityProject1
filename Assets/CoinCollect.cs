using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    public static int coin = 0;
    public TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Coin"))
        {
            coin++;
            coinText.text = "Score: " + coin.ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if (coin >= 1)
        {
            // Sla de score op in PlayerPrefs wanneer de timer stopt
            PlayerPrefs.SetInt("FinalScore", coin);
        }
    }
}   