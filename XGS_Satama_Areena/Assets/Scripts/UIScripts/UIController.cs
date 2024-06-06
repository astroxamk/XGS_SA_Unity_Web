using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header ("Control Buttons")]
    public Button MenuBtn;
    public KeyCode menuKey = KeyCode.Space;

    // Make this private in final file
    [Header ("Screen Height for Mobile Settings view")]
    public float screenHeight = 720f;

    [Header ("Main Menu Genrals")]
    public GameObject SettingsView;
    public PlayerCam playerCamera;
    public GameObject settingsLeft;

    public bool isSettingsViewActive = false;

    void Start() { MenuBtn.onClick.AddListener(HandleMainMenuBtn); }

    private void Update() {
        if (Input.GetKeyDown(menuKey))
            HandleMainMenuBtn();
    }

    /// <summary>
    /// A method that handles the main menu button
    /// </summary>
    void HandleMainMenuBtn() {
        isSettingsViewActive = !isSettingsViewActive;
        SettingsView.SetActive(isSettingsViewActive);

        if(isSettingsViewActive) {
            EnableMouse();

            if (Screen.height > screenHeight)
                settingsLeft.SetActive(true);
            else
                settingsLeft.SetActive(false);
        }
        else
            DisableMouse();

        bool newState = !playerCamera.enabled;
        playerCamera.enabled = newState;
    }

    /// <summary>
    /// A simple method to disable the mouse
    /// </summary>
    public void DisableMouse() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    /// <summary>
    /// A simple method to enable the mouse
    /// </summary>
    public void EnableMouse() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
