using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public TMP_Text finalScoreText; // Assign in Inspector
    public Score scoreManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        finalScoreText.text = $"Score: {scoreManager.GetScore()}"; // Display score
        Time.timeScale = 0f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
