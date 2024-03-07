using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int sceneBuildIndex;
    public string PlayerExitPos;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
    if (collision.CompareTag("Player")) // Check if colliding with player
        {
            print("Moving to next scene...");

            // Load the scene and find the corresponding entry point
            
            GameObject entryPoint = GameObject.Find("PlayerExitPos");

            // If entry point found, teleport player there
            if (entryPoint != null)
            {
                GameObject player = GameObject.FindWithTag("Player"); // Find player GameObject
                player.transform.position = entryPoint.transform.position;
            }
            else
            {
                Debug.LogError("No entry point found: " + PlayerExitPos); // Log error if entry point not found
            }
            
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }

}

