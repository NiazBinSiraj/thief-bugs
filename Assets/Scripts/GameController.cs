using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text textScore;
    public Text textLives;
    public Text textGameOver;

    private int score = 0;
    private int lives = 6;

    void Start()
    {
        textScore.text = "Score: " + score.ToString();
        textLives.text = "Lives: " + lives.ToString();
    }

    public void IncreaseScore()
    {
        score++;
        textScore.text = "Score: " + score.ToString();
    }

    public void DecreaseLife()
    {
        lives--;
        textLives.text = "Lives: " + lives.ToString();
        if (lives == 0)
        {
            Time.timeScale = 0;
            textGameOver.enabled = true;
        }
    }
}
