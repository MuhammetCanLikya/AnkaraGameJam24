using UnityEngine;

public class ScreenShaker : MonoBehaviour
{
    public Transform cameraTransform; // Reference to the main camera's transform
    public float shakeDuration = 0.1f; // Duration of the screen shake
    public float shakeIntensity = 0.3f; // Intensity of the shake

    private Vector3 originalCameraPosition; // Original position of the camera
    private float shakeTimer = 0f; // Timer for the shake

    void Start()
    {
        if (cameraTransform == null)
        {
            cameraTransform = Camera.main.transform;
        }
        originalCameraPosition = cameraTransform.localPosition;
    }

    void Update()
    {
        if (shakeTimer > 0)
        {
            // Shake the camera
            cameraTransform.localPosition = originalCameraPosition + Random.insideUnitSphere * shakeIntensity;

            // Reduce the shake timer
            shakeTimer -= Time.deltaTime;
        }
        else
        {
            // Reset the camera position when shake duration ends
            shakeTimer = 0f;
            cameraTransform.localPosition = originalCameraPosition;
        }
    }

    // Call this method to start the screen shake
    public void ShakeScreen()
    {
        shakeTimer = shakeDuration;
    }
}