using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerLimited : MonoBehaviour
{
    public Text textScore;
    public Text textTimeRemaining;
    public Text textGameOver;

    public float initTimeInSeconds = 12;
    
    private float elapsedTimeInSeconds = 0f;
    private float timeRemainingInSeconds;
    private int score = 0;
    private int lives = 6;

    void Start()
    {
        textScore.text = "Score: " + score.ToString();
        timeRemainingInSeconds = initTimeInSeconds;
        textTimeRemaining.text = "Time: " + ((int)timeRemainingInSeconds).ToString();
    }

    public void IncreaseScore()
    {
        score++;
        textScore.text = "Score: " + score.ToString();
    }

    public void DecreaseLife()
    {
        lives--;
        if (lives == 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Time.timeScale = 0;
        textGameOver.enabled = true;
    }

    void Update()
    {
        elapsedTimeInSeconds += Time.deltaTime;
        timeRemainingInSeconds -= Time.deltaTime;

        textTimeRemaining.text = "Time: " + ((int)timeRemainingInSeconds).ToString();

        if (timeRemainingInSeconds <= 0)
        {
            Die();
        }
    }
}
