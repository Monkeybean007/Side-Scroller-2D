using UnityEngine;
using TMPro;
using System.Collections;

public class PowerUpMessageUI : MonoBehaviour
{
    public TMP_Text messageText; // Reference to the Text Mesh Pro text element.

    private void Start()
    {
        // Initially, make the message text invisible.
        messageText.enabled = false;
    }

    public void ShowMessage(string message)
    {
        // Display the provided message on the Text Mesh Pro text element.
        messageText.text = message;
        messageText.enabled = true;

        // Start a coroutine to hide the message after a few seconds.
        StartCoroutine(HideMessage());
    }

    private IEnumerator HideMessage()
    {
        // Wait for 5 seconds (adjust this time as needed).
        yield return new WaitForSeconds(5.0f);

        // Hide the message after waiting.
        messageText.enabled = false;
    }
}
