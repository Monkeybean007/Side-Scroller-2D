using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;          // The player's Transform to follow.
    public float smoothSpeed = 0.125f; // The smoothing factor for camera movement. Adjust as needed.
    public Vector3 offset;            // The offset distance between the player and the camera.

    private void LateUpdate()
    {
        if (target == null)
        {
            // If the target is not assigned, exit the function.
            return;
        }

        // Calculate the desired position for the camera.
        Vector3 desiredPosition = target.position + offset;

        // Use Vector3.Lerp to smoothly interpolate between the current camera position and the desired position.
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the camera's position to the smoothed position.
        transform.position = smoothedPosition;
    }
}
