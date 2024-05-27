using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [Header("Sensitivity")]
    public float mouseSensitivity = 100f;

    [Header("Player Orientation")]
    public Transform playerBody;

    float xRotation = 0f;

    public void DisableCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // Mouse Inputs
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * mouseSensitivity;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
