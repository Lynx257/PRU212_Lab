using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        DisplayScore();
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

    public int GetScore()
    {
        return score;
    }
}
