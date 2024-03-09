using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string nextSceneName; // Name of the next scene

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print("Moving to next scene...");

            // Save the player's current position
            Vector2 playerExitPoint = collision.transform.position;

            // Load the next scene asynchronously
            StartCoroutine(LoadNextSceneAsync(playerExitPoint));
        }
    }

    private IEnumerator LoadNextSceneAsync(Vector2 playerExitPoint)
    {
        // Load the next scene asynchronously
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneName, LoadSceneMode.Single);

        // Wait until the next scene is fully loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Set the player's position in the new scene
        SetPlayerPosition(playerExitPoint);
    }

    private void SetPlayerPosition(Vector2 playerExitPoint)
    {
        GameObject player = GameObject.FindWithTag("Player");

        // If player found, teleport player to the saved position
        if (player != null)
        {
            player.transform.position = playerExitPoint;
        }
        else
        {
            Debug.LogError("Player not found in the new scene.");
        }
    }
}
