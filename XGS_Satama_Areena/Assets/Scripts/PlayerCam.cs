using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [Header("Sensitivity")]
    public float xAxisSens;
    public float yAxisSens;
    // [Header("Rotation")]
    float xAxisRot;
    float yAxisRot;

    [Header("Player Orientation")]
    public Transform orientation;

    public void DisableCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // Mouse Inputs
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * xAxisSens;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * yAxisSens;

        yAxisRot += mouseX;
        xAxisRot -= mouseY;
        xAxisRot = Mathf.Clamp(xAxisRot, -90f, 90f);

        // Rotate camera and orientation
        transform.rotation = Quaternion.Euler(xAxisRot, yAxisRot, 0);
        orientation.rotation = Quaternion.Euler(0, yAxisRot, 0);
    }
}
