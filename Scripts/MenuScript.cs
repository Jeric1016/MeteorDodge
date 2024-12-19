using UnityEngine;
using UnityEngine.SceneManagement;  // Required for SceneManager (new API for scene loading)

// <summary>
// Title screen script
// </summary>
public class MenuScript : MonoBehaviour
{
    // Method to start the game (loads the "InGame" scene)
    public void StartGame()
    {
        // Load the scene named "InGame"
        SceneManager.LoadScene("InGame");
    }

    // Method to exit the game
    public void ExitGame()
    {
        // Quit the game (only works in a built game, not in the editor)
        Debug.Log("Exiting the game...");
        Application.Quit();

        // If running in the editor, stop play mode (this won't stop the game in a build)
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
