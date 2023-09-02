using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health of the player.
    private int currentHealth; // Current health of the player.

    private void Start()
    {
        currentHealth = maxHealth; // Initialize current health to max health.
    }

    // Method to get the current health value
    public int GetCurrentHealth()
    {
        return currentHealth;
    }
    // Method to handle player taking damage.
    public void TakeDamage(int damage)
    {
        // Reduce player's health.
        currentHealth -= damage;

        // Check if the player has run out of health.
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Method to handle player's death.
    private void Die()
    {
        // Implement death behavior (e.g., play death animation, end game, etc.).

        // For this example, we'll simply deactivate the player GameObject.
        gameObject.SetActive(false);
    }
}
