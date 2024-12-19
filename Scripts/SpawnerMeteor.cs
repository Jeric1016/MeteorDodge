using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMeteor : MonoBehaviour
{
    public GameObject Meteor;        // Reference to the Meteor prefab
    public float spawnInterval = 0.5f; // Time between spawns
    private float timer = 0f;        // Timer to track time between spawns

    public float meteorSpeed = 2f;   // Speed of the meteors

    // Update is called once per frame
    void Update()
    {
        // Increment the timer by the time elapsed since the last frame
        timer += Time.deltaTime;

        // Check if enough time has passed to spawn meteors
        if (timer >= spawnInterval)
        {
            SpawnMeteors();   // Spawn meteors
            timer = 0f;       // Reset the timer
        }
    }

    // Method to spawn meteors at random positions along the x-axis
    void SpawnMeteors()
    {
        // Spawn the first meteor at a random position
        Vector2 posToSpawn1 = new Vector2(Random.Range(-7.26f, 7.26f), transform.position.y);
        GameObject meteor1 = Instantiate(Meteor, posToSpawn1, Quaternion.identity);

        // Set the speed for the meteor
        meteor1.GetComponent<Meteor>().speed = meteorSpeed;

        // Spawn the second meteor at a different random position
        Vector2 posToSpawn2 = new Vector2(Random.Range(-7.26f, 7.26f), transform.position.y);
        GameObject meteor2 = Instantiate(Meteor, posToSpawn2, Quaternion.identity);

        // Set the speed for the second meteor
        meteor2.GetComponent<Meteor>().speed = meteorSpeed;
    }
}
