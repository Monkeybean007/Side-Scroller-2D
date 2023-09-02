using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text gameOverText; // Reference to the UI Text element to display "Game Over" message.
    public PlayerHealth playerHealth; // Reference to the PlayerHealth script/component.
    public GameObject player; // Reference to the Player.

    void Start()
    {
        // Initialize the "Game Over" message text.
        gameOverText.gameObject.SetActive(false); // Initially hide the text.
    }

    void Update()
    {
        // Check if the player's health has reached zero or below.
        if (playerHealth.GetCurrentHealth() <= 0)
        {
            // Player has died.
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        // Show the "Game Over" message.
        gameOverText.gameObject.SetActive(true);
    }
}
