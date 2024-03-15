using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestSpawner : MonoBehaviour
{
    public GameObject playerPrefab; // Drag and drop the PLAYER Prefab into this field in the Unity Editor
    public Vector2 questDefault; // Set the default spawn position in the Unity Editor
    public int sceneBuildIndex;
    public bool isExiting = false;
    
    // Start is called before the first frame update
    void Start()
    {
        // Spawn the player at the default spawn position when the scene starts
        Vector2 spawnPosition = questDefault;
        // Spawn the player at the default spawn position when the scene starts
        SpawnPlayer(spawnPosition);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Update the class-level variable instead of declaring a new one
        isExiting = true;

        // Load the new scene
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);

        // Instantiate the player prefab at the specified spawn position
        GameObject player = Instantiate(playerPrefab, transform.position, Quaternion.identity);
        // Optionally, you can parent the spawned player to the HouseSpawner GameObject:
        player.transform.parent = transform;
    }

    void SpawnPlayer(Vector2 spawnPosition)
    {
        // Instantiate the player prefab at the specified spawn position
        GameObject player = Instantiate(playerPrefab, spawnPosition, Quaternion.identity);
        // Optionally, you can parent the spawned player to the QuestSpawner GameObject:
        player.transform.parent = transform;
    }
}
