using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Assign in the Inspector
    private int score = 0;
    private bool gameRunning = true;

    // Add points to the score
    public void AddScore(int points)
    {
        if (!gameRunning) return;

        score += points;
        UpdateScoreText();
    }

    // Stop scoring
    public void StopScoring()
    {
        if (!gameRunning) return;

        gameRunning = false;
        
    }

    // Update the score display to show only the number
    private void UpdateScoreText()
    {
        if (scoreText == null)
        {
            Debug.LogWarning("Score Text is not assigned in the Inspector!");
            return;
        }

        scoreText.text = score.ToString(); // Display only the number
    }
    
}
