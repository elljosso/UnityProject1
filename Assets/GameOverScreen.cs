using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        Cursor.visible = true;
    }
    public void Restart()
    {;
        SceneManager.LoadScene("Game1");
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
        Debug.Log("The player has quit");
    }
}
