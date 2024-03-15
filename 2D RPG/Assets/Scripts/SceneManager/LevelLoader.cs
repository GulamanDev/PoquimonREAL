using System.Collections;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{ 
    public int sceneBuildIndex;
    private int currentSceneBuildIndex;

    private bool sceneTransitionInitiated = false;

    private void Start()
    {
        currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !sceneTransitionInitiated)
        {
            sceneTransitionInitiated = true;
            StartCoroutine(LoadNewSceneAsync());
        }
    }

    IEnumerator LoadNewSceneAsync()
    {
        yield return SceneManager.LoadSceneAsync(sceneBuildIndex, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(currentSceneBuildIndex);
        sceneTransitionInitiated = false;
    }
}
/*public class LevelLoader : MonoBehaviour
{
    // Public variables for configuration
    public int sceneToLoadBuildIndex; // Scene to load using its build index
    public GameObject[] sceneGameObjects; // Array of scene-specific GameObjects

    private void Start()
    {
        // Ensure sceneGameObjects array matches scene count in Build Settings
        if (sceneGameObjects.Length != SceneManager.sceneCountInBuildSettings)
        {
            Debug.LogError("sceneGameObjects array length does not match scene count in Build Settings. Please update the array.");
            return;
        }

        // Find references to scene-specific GameObjects in the current scene (if any)
        for (int i = 0; i < sceneGameObjects.Length; i++)
        {
            if (sceneGameObjects[i] == null)
            {
                sceneGameObjects[i] = GameObject.FindGameObjectWithTag("Scene" + i); // Look for tags if no direct references
            }
        }

        // Subscribe to scene loaded event for handling scene gameobjects
        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    private void FindSceneGameObjects() // Helper function to find scene objects
    {
        for (int i = 0; i < sceneGameObjects.Length; i++)
        {
            if (sceneGameObjects[i] == null)
            {
                sceneGameObjects[i] = GameObject.FindGameObjectWithTag("Scene" + i); // Look for tags if no direct references
            }
        }
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode) // Handle scene loaded event
    {
        FindSceneGameObjects(); // Ensure references are up-to-date after loading

        // If scene is loaded additively, find and activate the loaded scene's GameObject
        if (mode == LoadSceneMode.Additive)
        {
            int loadedSceneBuildIndex = scene.buildIndex;
            if (sceneGameObjects[loadedSceneBuildIndex] != null)
            {
                sceneGameObjects[loadedSceneBuildIndex].SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            int currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;

            // Check if the scene to load is valid (ensure it exists in Build Settings)
            if (sceneToLoadBuildIndex >= 0 && sceneToLoadBuildIndex < SceneManager.sceneCountInBuildSettings)
            {
                

                // If scene is already loaded, activate it and deactivate current scene
                if (SceneManager.GetSceneByBuildIndex(sceneToLoadBuildIndex).isLoaded)
                {
                    int loadedSceneBuildIndex = sceneToLoadBuildIndex;
                    if (sceneGameObjects[loadedSceneBuildIndex] != null)
                    {
                        sceneGameObjects[loadedSceneBuildIndex].SetActive(true);
                    }
                    if (sceneGameObjects[currentSceneBuildIndex] != null)
                    {
                        sceneGameObjects[currentSceneBuildIndex].SetActive(false);
                    }
                }
                else // Otherwise, load scene additively
                {
                    SceneManager.LoadScene(sceneToLoadBuildIndex, LoadSceneMode.Additive);
                }
            }
            else
            {
                Debug.LogError("Invalid sceneToLoadBuildIndex: " + sceneToLoadBuildIndex);
            }
        }
    }

    private void OnDestroy() // Unsubscribe from event when script is destroyed
    {
        SceneManager.sceneLoaded -= OnLevelLoaded;
    }
}*/


/*public class LevelLoader : MonoBehaviour
{
    // Public variables for configuration
    public int sceneToLoadBuildIndex; // Scene to load using its build index
    public GameObject[] sceneGameObjects; // Array of scene-specific GameObjects

    private void Start()
    {
        // Ensure sceneGameObjects array matches scene count in Build Settings
        if (sceneGameObjects.Length != SceneManager.sceneCountInBuildSettings)
        {
            Debug.LogError("sceneGameObjects array length does not match scene count in Build Settings. Please update the array.");
            return;
        }

        // Find references to scene-specific GameObjects in the current scene (if any)
        for (int i = 0; i < sceneGameObjects.Length; i++)
        {
            if (sceneGameObjects[i] == null)
            {
                sceneGameObjects[i] = GameObject.FindGameObjectWithTag("Scene" + i); // Look for tags if no direct references
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            int currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;

            // Check if the scene to load is valid
            if (sceneToLoadBuildIndex >= 0 && sceneToLoadBuildIndex < SceneManager.sceneCountInBuildSettings)
            {
                // If scene isn't already loaded, load it additively
                if (!SceneManager.GetSceneByBuildIndex(sceneToLoadBuildIndex).isLoaded)
                {
                    SceneManager.LoadScene(sceneToLoadBuildIndex, LoadSceneMode.Additive);
                }

                // If scene is already loaded, activate it and deactivate current scene
                if (SceneManager.GetSceneByBuildIndex(sceneToLoadBuildIndex).isLoaded)
                {
                    int loadedSceneBuildIndex = sceneToLoadBuildIndex;
                    if (sceneGameObjects[loadedSceneBuildIndex] != null)
                    {
                        sceneGameObjects[loadedSceneBuildIndex].SetActive(true);
                    }
                    if (sceneGameObjects[currentSceneBuildIndex] != null)
                    {
                        sceneGameObjects[currentSceneBuildIndex].SetActive(false);
                    }
                }

                // Deactivate current scene's GameObject (if found)
                if (sceneGameObjects[currentSceneBuildIndex] != null)
                {
                    sceneGameObjects[currentSceneBuildIndex].SetActive(false);
                }
            }
            else
            {
                Debug.LogError("Invalid sceneToLoadBuildIndex: " + sceneToLoadBuildIndex);
            }
        }
    }
}*/

/*
public class LevelLoader : MonoBehaviour
{
    //  You can see the build index numbers sa Build Settings
    //  This is more organised since you can reference it by number instead of looking for their names
    //  Also good for future-proofing scenes
    public int sceneBuildIndex;
    public int currentSceneBuildIndex;
    public GameObject Village;
    public GameObject Forest;
    public GameObject Home;

    private void Start()
    {
        Village = GameObject.FindGameObjectWithTag("Village");
        Forest = GameObject.FindGameObjectWithTag("Forest");
        Home = GameObject.FindGameObjectWithTag("Home");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger entered.");

        if (collision.tag == "Player")
        {
            if ()
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Additive);

            switch (currentSceneBuildIndex)
            {
                case 0:
                    Village.SetActive(false);
                    break;
                case 1:
                    Forest.SetActive(false);
                    break;
                case 2:
                    Home.SetActive(false);
                    break;
            }
            

        }
    }
}*/


/*    private void OnTriggerEnter2D(Collider2D collision)
    {
        //  AYOKO NA, MANUAL KO NA LANG LOL
        print("Trigger entered.");

        if (collision.tag == "Forest Enter")
        {
            Forest.SetActive(true);
            Village.SetActive(false);
        }
        else if (collision.tag == "Village Enter")
        {
            Village.SetActive(true);
            Forest.SetActive(false);
        }
        else if (collision.tag == "Home Enter")
        {
            Home.SetActive(true);
            Forest.SetActive(false);
        }
        else if (collision.tag == "Home Exit")
        {
            Forest.SetActive(true);
            Home.SetActive(false);
        }
    }
}*/

//  SORRY, my brain stopped functioning and decided to reset the level loader script
//  instead of trying to understand what's happening
/*    //  For future reference, can be changed to public int sceneBuildIndex
    //  Used instead of string nextSceneName in case you plan on regularly changing
    //  scene names.
    public string nextSceneName; // Name of the next scene*/

/*
public class LevelLoader : MonoBehaviour
{
    public int sceneBuildIndex;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Player"))
        {
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
*/

/*    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print("Moving to next scene...");
*/
/*
            // Save the player's current position
            Vector2 playerExitPoint = collision.transform.position;
*/
/*
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
