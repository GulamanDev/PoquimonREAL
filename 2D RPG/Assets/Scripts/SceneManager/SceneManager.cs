/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance = null;

    public GameObject player;
    public int []sceneBuildArray;

    public int currentBuildIndex;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if (sceneBuildArray == null)
        {
            sceneBuildArray = GameObject.FindGameObjectWithTag("Spawnpoint");
        }
    }

    private void OnLevelWasLoaded()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        sceneBuildArray = GameObject.FindGameObjectWithTag("Spawnpoint");
    }

    public void LoadScene(int usedSceneBuildIndex)
    {
        currentBuildIndex = usedSceneBuildIndex;

        if (SceneManager.LoadScene(sceneBuildArray))
        {
            SceneManager.LoadScene(1);
        }
    }
}
*/