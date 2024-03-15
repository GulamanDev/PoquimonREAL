/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentDataManager : MonoBehaviour
{
    public Vector3 playerPosition;
    public List<string> inactiveGameObjectNames;

    void Awake()
    {
        // Ensure this object persists across scene loads
        DontDestroyOnLoad(this);
    }

    // Methods to set and retrieve player position and inactive GameObject list
    public void SetPlayerPosition(Vector3 position)
    {
        playerPosition = position;
    }

    public Vector3 GetPlayerPosition()
    {
        return playerPosition;
    }

    public void SetInactiveGameObjects(List<string> names)
    {
        inactiveGameObjectNames = names;
    }

    public List<string> GetInactiveGameObjects()
    {
        return inactiveGameObjectNames;
    }
}*/