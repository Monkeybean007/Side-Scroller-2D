using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damageAmount = 20; // The amount of damage the player's attack deals.
    public float attackRange = 1.0f; // The range of the player's attack.

    private void Update()
    {
        // Check for player input to trigger the attack (e.g., using a button press).
        if (Input.GetMouseButtonDown(0)) // Change this to your desired input method.
        {
            Attack();
        }
    }

    private void Attack()
    {
        // Check for enemies in attack range.
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, attackRange);

        foreach (Collider2D collider in hitColliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                // Get the Enemy component from the enemy GameObject.
                Enemy enemy = collider.GetComponent<Enemy>();

                // Check if the enemy has an Enemy component.
                if (enemy != null)
                {
                    // Deal damage to the enemy.
                    enemy.TakeDamage(damageAmount);
                }
            }
        }

        // Play your attack animation or sound here.
    }
}
