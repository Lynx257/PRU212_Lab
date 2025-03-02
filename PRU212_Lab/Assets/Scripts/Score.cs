using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        DisplayScore();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void DisplayScore()
    {
        scoreText.text = $"Score: {score}";
    }

    public void EnemyKilled()
    {
        score++;
        DisplayScore();
    }
}
