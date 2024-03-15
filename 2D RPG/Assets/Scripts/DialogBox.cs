
using UnityEngine;
using TMPro;

public class DialogBox : MonoBehaviour
{
    public TextMeshProUGUI dialogText;

    // Method to check if the dialog box is active
    public bool IsDialogActive()
    {
        // Return true if the dialog box game object is active
        return gameObject.activeSelf;
    }

    // Method to show the dialog box
    public void ShowDialog(string text)
    {
        // Show the dialog box and set the text
        gameObject.SetActive(true);
        dialogText.text = text;
    }

    // Method to hide the dialog box
    public void HideDialog()
    {
        // Hide the dialog box
        gameObject.SetActive(false);
    }
}
