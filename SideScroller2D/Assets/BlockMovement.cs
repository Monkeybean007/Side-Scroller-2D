using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public float speed = 2.0f; // Speed of movement.
    public float distance = 5.0f; // Distance to move back and forth.
    public bool moveOnXAxis = true; // Set to true to move on the X-axis, false for the Y-axis or Z-axis.

    private Vector3 startPosition;
    private Vector3 endPosition;
    private Vector3 direction;
    private bool movingToEnd = true;

    void Start()
    {
        // Store the initial position of the GameObject.
        startPosition = transform.position;

        // Calculate the end position based on the chosen axis and distance.
        if (moveOnXAxis)
        {
            endPosition = startPosition + Vector3.right * distance;
            direction = Vector3.right;
        }
        else
        {
            endPosition = startPosition + Vector3.up * distance; // Change Vector3.up to Vector3.forward for Z-axis movement.
            direction = Vector3.up;
        }
    }

    void Update()
    {
        // Move the object back and forth.
        if (movingToEnd)
        {
            transform.Translate(direction * speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, endPosition) >= distance)
                movingToEnd = false;
        }
        else
        {
            transform.Translate(-direction * speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, startPosition) <= 0.01f)
                movingToEnd = true;
        }
    }
}
