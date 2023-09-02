using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health of the enemy.
    private int currentHealth; // Current health of the enemy.

    private void Start()
    {
        currentHealth = maxHealth; // Initialize current health to max health.
    }

    // Function to take damage from the character.
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Check if the enemy has been defeated.
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Function to handle enemy death.
    private void Die()
    {
        // Add any death behavior here, such as playing an animation, dropping items, or removing the enemy from the scene.
        Destroy(gameObject); // Destroy the enemy GameObject when it's defeated.
    }

    // You can add more enemy behavior and AI logic here as needed.
}
