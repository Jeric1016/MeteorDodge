using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed, EdgeSceen;
    Rigidbody2D rg2d;

    private float move = 0;

    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Handle screen touches
        HandleTouchInput();

        // Restrict the player’s movement to the screen boundaries
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -EdgeSceen, EdgeSceen),
                                         transform.position.y);

        // Apply velocity based on the move direction
        rg2d.velocity = new Vector2(move * speed, 0);
    }

    // Handle the touch input
    void HandleTouchInput()
    {
        if (Input.touchCount > 0) // Check if there is a touch
        {
            Touch touch = Input.GetTouch(0); // Get the first touch

            // Get the touch position relative to the screen
            Vector2 touchPosition = touch.position;

            // If the touch position is on the right side of the screen, move right
            if (touchPosition.x > Screen.width / 2)
            {
                move = 1;  // Move to the right
            }
            // If the touch position is on the left side of the screen, move left
            else
            {
                move = -1; // Move to the left
            }
        }
        else
        {
            // No touch, stop moving the player
            move = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D Meteor)
    {
        if (Meteor.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(Meteor.gameObject);
        }
    }
}
