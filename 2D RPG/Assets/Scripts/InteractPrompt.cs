// InteractPrompt.cs
using UnityEngine;
using TMPro;

public class InteractPrompt : MonoBehaviour
{
    public TextMeshProUGUI promptText;

    public void ShowPrompt(string text)
    {
        // Show the prompt and set the text
        gameObject.SetActive(true);
        promptText.text = text; // Line 14
    }

    public void HidePrompt()
    {
        // Hide the prompt
        gameObject.SetActive(false);
    }
}
