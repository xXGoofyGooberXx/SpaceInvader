using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Duration of the shake effect
    public float shakeDuration = 0.5f;

    // Magnitude of the shake (how intense it is)
    public float shakeMagnitude = 0.2f;

    // How quickly the shake effect diminishes
    public float dampingSpeed = 1.0f;

    // Store the original position of the camera
    private Vector3 initialPosition;

    // To keep track of when shaking
    private float currentShakeDuration = 0f;

    void Start()
    {
        // Save the original position of the camera
        initialPosition = transform.localPosition;
    }

    // Call this function to trigger the shake
    public void TriggerShake()
    {
        currentShakeDuration = shakeDuration;
    }

    void Update()
    {
        // If shake duration is positive, apply the shake effect
        if (currentShakeDuration > 0)
        {
            // Generate random shake within a sphere to simulate shaking
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            // Reduce shake duration based on time
            currentShakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            // Reset position when shake ends
            currentShakeDuration = 0f;
            transform.localPosition = initialPosition;
        }

     
    }
 

}
