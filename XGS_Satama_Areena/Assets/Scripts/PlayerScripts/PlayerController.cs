using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Character Controller")]
    public CharacterController controller;
    public float speed = 12f;
    public Joystick joystick;
    public GameObject mobileControls;

    [Header ("Check Ground")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    [Header ("Remember to delete from final file")]
    public UIController uiController;

    Vector3 velocity;
    bool isGrounded;

    private void Update()
    {
        if (mobileControls.activeInHierarchy == true) {
            TouchControls();
            // Delete this line from final file
            uiController.EnableMouse();
        }
        else{
            if (uiController.isSettingsViewActive == false)
                KeyboardControls();
        }
        HandlePhysicsInGame();
    }

    /// <summary>
    /// Method to control the player with the touch controls
    /// </summary>
    void TouchControls() {
        float horizontalMovementMobile = joystick.Horizontal;
        float verticalMovementMobile = joystick.Vertical;

        Vector3 movePlayerMobile = transform.right * horizontalMovementMobile + transform.forward * verticalMovementMobile;

        controller.Move(movePlayerMobile * Time.deltaTime * speed);
    }

    /// <summary>
    /// Method to control the player with the keyboard
    /// </summary>
    void KeyboardControls() {
        float horizontalMovementKeyboard = Input.GetAxis("Horizontal");
        float verticalMovementKeyboard = Input.GetAxis("Vertical");

        Vector3 movePlayerKeyboard = transform.right * horizontalMovementKeyboard + transform.forward * verticalMovementKeyboard;

        controller.Move(movePlayerKeyboard * Time.deltaTime * speed);
    }
    
    /// <summary>
    /// Method to handle the basic physics of the player
    /// </summary>
    void HandlePhysicsInGame() {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
            velocity.y = -2f;

        velocity.y += Physics.gravity.y * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
