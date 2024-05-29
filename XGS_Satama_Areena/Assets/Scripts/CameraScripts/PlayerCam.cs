using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [Header("Sensitivity")]
    public float mouseSensitivity = 100f;
    public float touchSensitivity = 50f;

    [Header("Player Orientation")]
    public Transform playerBody;

    float xRotation = 0f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            TouchCam();
        }
        else
        {
            KeyboardCam();
        }
    }

    void TouchCam()
    {
        if(Input.touchCount > 0 && )
        {

        }
    }

    void KeyboardCam()
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
