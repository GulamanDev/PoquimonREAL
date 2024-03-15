using UnityEngine;
using System.Collections.Generic;

public class EnemyDialogBox : MonoBehaviour
{
    public DialogBox dialogBox;
    public KeyCode nextLineKey = KeyCode.Mouse0; // Left mouse button

    private List<string> dialogLines = new List<string>();
    private int currentLineIndex = 0;

    private void Start()
    {
        // Add your dialog lines here
        dialogLines.Add("Bulbasaur!");
        dialogLines.Add("A wild Bulbasaur appeared!");
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider belongs to the player
        if (other.CompareTag("Player"))
        {
            // Start the dialogue when the player enters the trigger area
            StartDialog();
        }
    }

    private void Update()
    {
        // Check for left mouse button press to proceed to the next line
        if (Input.GetKeyDown(nextLineKey))
        {
            NextLine();
        }
    }

    public void StartDialog()
    {
        // Reset the line index
        currentLineIndex = 0;

        // Show the dialog box with the first line
        dialogBox.ShowDialog(dialogLines[currentLineIndex]);
    }

    private void NextLine()
    {
        // Increment the line index
        currentLineIndex++;

        // Check if there are more lines
        if (currentLineIndex < dialogLines.Count)
        {
            // Show the next line
            dialogBox.ShowDialog(dialogLines[currentLineIndex]);
        }
        else
        {
            // Hide the dialog box when all lines are displayed
            dialogBox.HideDialog();
        }
    }
}
