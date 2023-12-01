using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 3f; // Adjust this value to control the speed of the enemy.
    public float detectionRange = 10f; // Adjust this value to control how far the enemy can detect the player.

    private Transform player; // Reference to the player's transform.
    private bool canMove = true; // Control whether the enemy can move.

    void Start()
    {
        // Find the player GameObject by tag. Make sure your player has the tag "Player".
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Player not found! Make sure the player has the tag 'Player'.");
        }
    }

    void Update()
    {
        // Check if the player is within the detection range.
        if (Vector2.Distance(transform.position, player.position) < detectionRange && canMove)
        {
            // Move towards the player.
            MoveTowardsPlayer();
        }
    }

    void MoveTowardsPlayer()
    {
        // Calculate the direction to the player.
        Vector2 direction = (player.position - transform.position).normalized;

        // Move the enemy towards the player using Translate.
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    // Call this method from an Animation Event in your sprite animation.
    void StopMoving()
    {
        canMove = false;
    }
}
