using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject gameWinUI;
    private bool isGameOver = false;
    private bool isGameWin = false;
    void Start()
    {
        StartGame();
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int points)
    {
        if (!isGameOver &&!isGameWin)
        {
            score += points;
            UpdateScore();
        }
    }

    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
    }

    public void GameWin()
    {
        isGameWin = true;
        Time.timeScale = 0;
        gameWinUI.SetActive(true);
    }

    public void StartGame()
    {
        score = 0;
        isGameOver = false;
        Time.timeScale = 1;
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    public bool IsGameWin()
    {
        return isGameWin;
    }
}
