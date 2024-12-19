using UnityEngine;

public class Meteor : MonoBehaviour
{
    public int scoreValue = 1; // Points for hitting the ground
    public float speed = 2f;   // Speed of the meteor's fall

    private void Start()
    {
        // Set the velocity of the meteor when it spawns
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector2(0, -speed); // Moving downwards with the specified speed
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            // Add score when the meteor hits the ground
            FindObjectOfType<ScoreManager>().AddScore(scoreValue);
            Destroy(gameObject); // Destroy the meteor
        }
        else if (other.CompareTag("Player"))
        {
            // Stop scoring when the meteor hits the player
            FindObjectOfType<ScoreManager>().StopScoring();
            Destroy(gameObject); // Destroy the meteor
        }
    }
}
