using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] int damage = 10; // Amount of damage the enemy deals to the player.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the method is being called.
        Debug.Log("OnTriggerEnter2D called");
        // Check if the collision is with the player (assuming the player has a "Player" tag).
        if (collision.CompareTag("Player"))
        {
            // Check if the enemy detects the player.
            Debug.Log("Player detected by enemy");
            // Get the PlayerHealth component from the player GameObject.
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

            // Check if the PlayerHealth component is not null (the player has the script).
            if (playerHealth != null)
            {
                // Inflict damage to the player.
                playerHealth.TakeDamage(damage);
            }
        }
    }
}
