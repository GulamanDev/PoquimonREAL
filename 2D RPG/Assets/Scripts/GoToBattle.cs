using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToBattle : MonoBehaviour
{
    EnemyDialogBox enemyDialogBox;

    public int sceneBuildIndex;
    private int currentSceneBuildIndex;

    bool isDialogActive = false;
    bool hasLoadedScene = false;
    private bool sceneTransitionInitiated = false;

    // Start is called before the first frame update
    void Start()
    {
        // Find the EnemyDialogBox script in the scene
        enemyDialogBox = FindObjectOfType<EnemyDialogBox>();

        // Start the dialog when the script starts
        enemyDialogBox.StartDialog();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the EnemyDialogBox script exists and if dialog is active
        if (enemyDialogBox != null && enemyDialogBox.dialogBox.IsDialogActive())
        {
            // Set the flag to indicate dialog is active
            isDialogActive = true;
        }
        else
        {
            // Reset the flag if dialog is not active
            isDialogActive = false;
        }

        // If dialog is active or scene is already loaded, return without loading the scene
        if (isDialogActive || hasLoadedScene)
        {
            return;
        }

        // Load the battle scene once the dialog box is hidden or not active
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        /*sceneTransitionInitiated = true;
        StartCoroutine(LoadNewSceneAsync());
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Additive);

        IEnumerator LoadNewSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync(sceneBuildIndex, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(currentSceneBuildIndex);
            sceneTransitionInitiated = false;
        }*/

        // Set the flag to indicate scene is loaded to avoid reloading
        hasLoadedScene = true;
    }
}