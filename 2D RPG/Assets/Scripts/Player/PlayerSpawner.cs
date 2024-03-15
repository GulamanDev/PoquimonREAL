using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab; // Drag and drop the PLAYER Prefab into this field in the Unity Editor
    public Vector2 defaultSpawn; // Set the default spawn position in the Unity Editor
    public Vector2 houseExit; // Set the spawn position when exiting the house
    public Vector2 map2Exit; // Set the spawn position when exiting Map 2

    [SerializeField]HouseSpawner houseSpawner;
    [SerializeField]QuestSpawner questSpawner;

    void Start()
    {
        // Find the HouseSpawner and QuestSpawner scripts in the scene
        houseSpawner = FindObjectOfType<HouseSpawner>();
        questSpawner = FindObjectOfType<QuestSpawner>();

        // Spawn the player at the default spawn position when the scene starts
        Vector2 spawnPosition = defaultSpawn;
        SpawnPlayer(spawnPosition);
    }

    void Update()
    {
        CheckExit();
    }

    void CheckExit()
    {
        // Check if HouseSpawner is exiting
        if (houseSpawner != null && houseSpawner.isExiting)
        {
            // Set spawn position to houseExit
            Vector2 spawnPosition = houseExit;
            // Spawn the player at houseExit
            SpawnPlayer(spawnPosition);
        }
        
        // Add additional conditions here if needed for other spawners

         if (questSpawner != null && questSpawner.isExiting)
        {
            // Set spawn position to houseExit
            Vector2 spawnPosition = map2Exit;
            // Spawn the player at houseExit
            SpawnPlayer(spawnPosition);
        }
    }

    void SpawnPlayer(Vector2 spawnPosition)
    {
        // Instantiate the player prefab at the specified spawn position
        GameObject player = Instantiate(playerPrefab, spawnPosition, Quaternion.identity);
        // Optionally, you can parent the spawned player to the PlayerSpawner GameObject:
        player.transform.parent = transform;
    }
}

