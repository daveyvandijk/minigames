using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraSwitch : MonoBehaviour
{
    public Camera mainCamera;
    public Camera secondCamera;

    private bool isSecondCameraActive = false;

    private void Start()
    {
        // Activate the main camera at the start
        ActivateMainCamera();
    }

    private void Update()
    {
        // Check for input (e.g., mouse click) to switch cameras
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isSecondCameraActive)
            {
                ActivateMainCamera();
            }
            else
            {
                ActivateSecondCamera();
            }
        }
    }

    private void OnMouseDown()
    {
        if (!isSecondCameraActive)
        {
            // Get the world position of the mouse click
            Vector3 mouseWorldPos = GetMouseWorldPos();

            // Perform the task or mini-game logic for the clicked object
            PerformTask(mouseWorldPos);
        }
    }

    private void PerformTask(Vector3 mouseWorldPos)
    {
        // TODO: Implement your task or mini-game logic here
        Debug.Log("Performing task at: " + mouseWorldPos);
    }

    private Vector3 GetMouseWorldPos()
    {
        // Get the mouse position in screen space
        Vector3 mousePos = Input.mousePosition;

        // Convert the screen space mouse position to world space
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    private void ActivateMainCamera()
    {
        // Activate the main camera
        mainCamera.enabled = true;
        secondCamera.enabled = false;

        isSecondCameraActive = false;
    }

    private void ActivateSecondCamera()
    {
        // Activate the second camera
        mainCamera.enabled = false;
        secondCamera.enabled = true;

        isSecondCameraActive = true;
    }
}
