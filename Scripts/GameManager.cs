using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject gameOverText;

    public static float gameSpeed = 5f;

    private int highScore;

    void Start()
    {
        // Load saved high score
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore;
    }

    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = "Score: " + Mathf.FloorToInt(score);

        gameSpeed += 0.001f;
    }

    /*public void GameOver()
    {
        Time.timeScale = 0;
        gameOverText.SetActive(true);

        int finalScore = Mathf.FloorToInt(score);

        // Check and save new high score
        if (finalScore > highScore)
        {
            highScore = finalScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        */
        public TextMeshProUGUI finalScoreText; // Add this

public void GameOver()
{
    Time.timeScale = 0;
    gameOverText.SetActive(true);

    int finalScore = Mathf.FloorToInt(score);

    // Show final score
    finalScoreText.text = "Final Score: " + finalScore;

    // Check and save new high score
    if (finalScore > highScore)
    {
        highScore = finalScore;
        PlayerPrefs.SetInt("HighScore", highScore);
    }

    highScoreText.text = "High Score: " + highScore;
}

    }