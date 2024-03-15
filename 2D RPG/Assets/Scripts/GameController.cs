using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState { FreeRoam, Battle }

public class GameController : MonoBehaviour
{
    [SerializeField] BattleSystem battleSystem;
    [SerializeField] Camera worldCamera;

    GameState gameState;
    BattleState battleState;

    private void Start()
    {
        gameState = GameState.FreeRoam;
        battleState = BattleState.NONE;
    }

    void StartBattle()
    {
        gameState = GameState.Battle;
        battleState = BattleState.START;
        battleSystem.gameObject.SetActive(true);
        worldCamera.gameObject.SetActive(false);
    }

    void EndBattle(bool playerWon)
    {
        if (playerWon)
        {
            battleState = BattleState.WON;
        }
        else
        {
            battleState = BattleState.LOST;
        }

        // Load another scene
        SceneManager.LoadScene("Village - QuestEmpty");
    }

    public void Update()
    {
        if (gameState == GameState.FreeRoam)
        {
            worldCamera.gameObject.SetActive(true);
        }
        else if (gameState == GameState.Battle)
        {
            battleSystem.HandleUpdate();
        }
    }
}
