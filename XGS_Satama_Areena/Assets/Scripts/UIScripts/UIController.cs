using TMPro;
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
    public GameObject SettingsPc;
    public GameObject SettingsMobile;
    public PlayerCam playerCamera;
    public GameObject settingsLeft;

    [Header ("Control Settings Window")]
    public GameObject RightSettings;
    public GameObject RightSettingsAlternative;
    public GameObject RightSettingsMobile;
    public GameObject RightSettingsAlternativeMobile;
    public TextMeshProUGUI seatingText;
    public TextMeshProUGUI seatingTextMobile;
    public GameObject StairSeatings;

    public bool isSettingsViewActive = false;
    private bool isSeatingActive = false;

    void Start() { MenuBtn.onClick.AddListener(HandleMainMenuBtn); }

    private void Update() {
        if (Input.GetKeyDown(menuKey))
            HandleMainMenuBtn();

        if (isSeatingActive)
        {
            seatingText.text = "ON";
            seatingTextMobile.text = "ON";
        }
        else
        {
            seatingText.text = "OFF"; 
            seatingTextMobile.text = "OFF";
        }
    }

    /// <summary>
    /// A method that handles the main menu button
    /// </summary>
    void HandleMainMenuBtn() {
        isSettingsViewActive = !isSettingsViewActive;
        if (Screen.height <= screenHeight)
            SettingsPc.SetActive(isSettingsViewActive);
        else
            SettingsMobile.SetActive(isSettingsViewActive);

        if (isSettingsViewActive) {
            EnableMouse();

            if (Screen.height > screenHeight)
                settingsLeft.SetActive(true);
            else
                settingsLeft.SetActive(false);
        }
        else
            DisableMouse();

        if (Screen.height <= screenHeight)
        {
            bool newState = !playerCamera.enabled;
            playerCamera.enabled = newState;
        }
        RightSettings.SetActive(true);
        RightSettingsMobile.SetActive(true);
        RightSettingsAlternative.SetActive(false);
        RightSettingsAlternativeMobile.SetActive(false);
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

    public void HandleSeatings(){
        isSeatingActive = !isSeatingActive;
        StairSeatings.SetActive(isSeatingActive);
    }

    public void HandleMainSettingsWindow(){
        RightSettings.SetActive(false);
        RightSettingsMobile.SetActive(false);
        RightSettingsAlternative.SetActive(true);
        RightSettingsAlternativeMobile.SetActive(true);
    }
}
