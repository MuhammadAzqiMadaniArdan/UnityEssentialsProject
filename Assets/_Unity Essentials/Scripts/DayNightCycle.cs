using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("The duration in seconds for a full day cycle (from dawn to dusk and back to dawn).")]
    public float dayDurationInSeconds = 120f; // Default duration for a full day (2 minutes)

    // Private variable to store the rotation speed
    private float rotationSpeed;

    private void Start()
    {
        // Calculate the rotation speed based on the day duration
        // 360 degrees represents a full rotation (one day).
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    private void Update()
    {
        // Rotate the light around the X-axis
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
