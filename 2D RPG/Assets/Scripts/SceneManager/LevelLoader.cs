using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //  You can see the build index numbers sa Build Settings
    //  This is more organised since you can reference it by number instead of looking for their names
    //  Also good for future-proofing scenes
    public int sceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger entered.");

        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }


}

//  SORRY, my brain stopped functioning and decided to reset the level loader script
//  instead of trying to understand what's happening
/*    //  For future reference, can be changed to public int sceneBuildIndex
    //  Used instead of string nextSceneName in case you plan on regularly changing
    //  scene names.
    public string nextSceneName; // Name of the next scene*/



/*    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print("Moving to next scene...");
*//*
            // Save the player's current position
            Vector2 playerExitPoint = collision.transform.position;
*//*
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
}*/
