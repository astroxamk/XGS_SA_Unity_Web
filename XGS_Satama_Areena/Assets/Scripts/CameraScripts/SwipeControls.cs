using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeControls : MonoBehaviour
{
    [Header("Camera controls")]
    private Touch initTouch = new Touch();
    public Camera playerCam;
    public RectTransform joystick;

    // Rotation variables
    private float rotX = 0f;
    private float rotY = 0f;
    private Vector3 origRot;
    private Rect joystickArea;

    [Header("Rotation variables")]
    public float rotSpeed = 0.5f;
    [Range(-1, 1)]
    public int dir = -1;

    private void Start()
    {
        origRot = playerCam.transform.eulerAngles;
        rotX = origRot.x;
        rotY = origRot.y;

        Vector3[] corners = new Vector3[4];
        joystick.GetWorldCorners(corners);
        joystickArea = new Rect(corners[0].x, corners[0].y, corners[2].x - corners[0].x, corners[2].y - corners[0].y);
    }
    private void FixedUpdate()
    {
        foreach (Touch touch in Input.touches)
        {

            if (touch.phase == TouchPhase.Began)
            {
                if(IsTouchingJoystickArea(touch.position))
                {
                    initTouch = touch;
                }
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                if (!IsTouchingJoystickArea(touch.position))
                {
                    float deltaX = initTouch.position.x - touch.position.x;
                    float deltaY = initTouch.position.y - touch.position.y;

                    rotX -= deltaY * Time.deltaTime * rotSpeed * dir;
                    rotY += deltaX * Time.deltaTime * rotSpeed * dir;

                    rotX = Mathf.Clamp(rotX, -90f, 90f);

                    playerCam.transform.eulerAngles = new Vector3(rotX, rotY, 0f);
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                initTouch = new Touch();
            }
        }
    }

    bool IsTouchingJoystickArea(Vector2 touchPosition)
    {
        return RectTransformUtility.RectangleContainsScreenPoint(joystick, touchPosition, Camera.main);
    }
}
