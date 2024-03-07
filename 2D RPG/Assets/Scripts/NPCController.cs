using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    [SerializeField] Dialog dialog;

    // Called when a 2D collision occurs
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");
        if (collision.gameObject.CompareTag("Player")) // Check if colliding with player
        {
            print("Moving to next scene...");
            Interact();
        }
    }

    public void Interact()
    {
        print("Interact method called");
        DialogManager.Instance.ShowDialog(dialog);
    }
}
