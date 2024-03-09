// DialogManager.cs
using UnityEngine;
using System.Collections.Generic;

public class DialogManager : MonoBehaviour
{
    public DialogBox dialogBox;
    public InteractPrompt interactPrompt;
    public KeyCode interactKey = KeyCode.E;
    public KeyCode nextLineKey = KeyCode.Mouse0; // Left mouse button

    private List<string> dialogLines = new List<string>();
    private int currentLineIndex = 0;

    private void Start()
    {
        // Add your dialog lines here
        dialogLines.Add("Hello, this is the first line.");
        dialogLines.Add("This is the second line.");
        dialogLines.Add("And here's the third line.");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            interactPrompt.ShowPrompt("Press E to interact");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            interactPrompt.HidePrompt();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(interactKey) && interactPrompt.gameObject.activeSelf)
        {
            // Start the dialogue when the player presses the interact key
            StartDialog();
        }

        // Check for left mouse button press to proceed to the next line
        if (Input.GetKeyDown(nextLineKey) && dialogBox.gameObject.activeSelf)
        {
            NextLine();
        }
    }

    private void StartDialog()
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
