// DialogBox.cs
using UnityEngine;
using TMPro;

public class DialogBox : MonoBehaviour
{
    public TextMeshProUGUI dialogText;

    public void ShowDialog(string text)
    {
        // Show the dialog box and set the text
        // You can customize the appearance and behavior here
        gameObject.SetActive(true);
        dialogText.text = text;
    }

    public void HideDialog()
    {
        // Hide the dialog box
        gameObject.SetActive(false);
    }
}
