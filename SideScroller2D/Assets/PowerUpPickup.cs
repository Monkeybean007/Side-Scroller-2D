using UnityEngine;

public class PowerUpPickup : MonoBehaviour
{
    public PowerUpMessageUI messageUI; // Reference to the PowerUpMessageUI
    public AudioSource pickupAudio; // Reference to the AudioSource for pickup sound
    private bool isPickedUp = false;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true; // Ensure the rigidbody doesn't respond to physics until picked up.
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isPickedUp && other.CompareTag("Player"))
        {
            // Mark the power-up as picked up to prevent multiple pickups.
            isPickedUp = true;

            // Play the pickup sound.
            if (pickupAudio != null)
            {
                pickupAudio.Play();
            }

            // Print a message indicating the power-up was picked up.
            Debug.Log("Power-up picked up!");

            // You can add your power-up effects or logic here.
            // For example, you can increase the player's speed or enable a special ability.

            // Optionally, you can display a message on the UI.
            if (messageUI != null)
            {
                messageUI.ShowMessage("Power-up picked up!"); // Assuming your UI component has a ShowMessage method.
            }

            // Disable the renderer and collider so it appears picked up.
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            // Optionally, you can destroy the object after pickup.
            // Destroy(gameObject);
        }
    }
}
