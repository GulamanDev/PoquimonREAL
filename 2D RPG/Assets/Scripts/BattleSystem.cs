using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;
  

    public BattleState state;

    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
{
    GameObject playerObject = Instantiate(playerPrefab, playerBattleStation.position, Quaternion.identity);
    GameObject enemyObject = Instantiate(enemyPrefab, enemyBattleStation.position, Quaternion.identity);

    // Set the parent to ensure proper hierarchy
    playerObject.transform.SetParent(playerBattleStation);
    enemyObject.transform.SetParent(enemyBattleStation);
}

}
