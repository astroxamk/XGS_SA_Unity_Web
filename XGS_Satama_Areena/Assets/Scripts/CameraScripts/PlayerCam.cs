using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [Header("Sensitivity")]
    public float mouseSensitivity = 100f;

    [Header("Player Orientation")]
    public Transform playerBody;

    float xRotation = 0f;

    [Header("Camera controls")]
    private Touch initTouch = new Touch();

    // Rotation variables
    private float rotX = 0f;
    private float rotY = 0f;
    private Vector3 origRot;

    [Header("Rotation variables")]
    public float rotSpeed = 0.3f;
    [Range(-1, 1)]
    public int dir = -1;


    private void Start()
    {
        origRot = playerBody.transform.eulerAngles;
        rotX = origRot.x;
        rotY = origRot.y;
    }

    private void Update()
    {
        if(Screen.width <= 720f)
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

    private void FixedUpdate()
    {
        if(Screen.width > 720f)
        {
            if (Input.touchCount > 0)
            {
                for (int i = 0; i < Input.touchCount; i++)
                {
                    Touch touch = Input.GetTouch(i);
                    
                    if (touch.position.x > Screen.width / 2)
                    {
                        if (touch.phase == TouchPhase.Began)
                        {
                            initTouch = touch;
                        }
                        else if (touch.phase == TouchPhase.Moved)
                        {

                            float deltaX = initTouch.position.x - touch.position.x;
                            float deltaY = initTouch.position.y - touch.position.y;

                            rotX -= deltaY * Time.deltaTime * rotSpeed * dir;
                            rotY += deltaX * Time.deltaTime * rotSpeed * dir;

                            rotX = Mathf.Clamp(rotX, -90f, 90f);

                            playerBody.transform.eulerAngles = new Vector3(rotX, rotY, 0f);
                        }
                        else if (touch.phase == TouchPhase.Ended)
                        {
                            initTouch = new Touch();
                        }
                    }
                }
            }
        }
    }
}
