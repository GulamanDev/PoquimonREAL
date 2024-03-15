// Make A Game Like Pokemon in Unity | #12 - Starting and Ending Battles
// https://www.youtube.com/watch?v=R9XMOEFne7w&list=PLLf84Zj7U26kfPQ00JVI2nIoozuPkykDX&index=12


/*using System.Reflection.Metadata;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { FreeRoam, Battle }

public class GameController : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] BattleSystem battleSystem;
    [SerializeField] Camera worldCamera;

    GameState state;

    private void Start()
    {
        playerController.OnEncountered += StartBattle;
        battleSystem.OnBattleOver += EndBattle;
    }

    void StartBattle()
    {
        state = GameState.Battle;
        battleSystem.gameObject.SetActive(true);
        worldCamera.gameObject.SetActive(false);
    }

    void EndBattle(bool)
    {
        state =  GameState.FreeRoam;
        battleSystem.gameObject.SetActive(false);
        worldCamera.gameObject.SetActive(true);
    }

    public void Update() 
    {
        if (state == GameState.FreeRoam)
        {
            playerController.HandleUpdate();
        }
        else if (state == GameState.Battle)
        {
            battleSystem.HandleUpdate();
        }
    }
}*/
//If BattleSystem.cs is made. Note to change "private void Update" to "public void Update".
//To be Cont.
//Lots of reference to BattleSystem
//Waiting for that to be made before tweaking most of the code
