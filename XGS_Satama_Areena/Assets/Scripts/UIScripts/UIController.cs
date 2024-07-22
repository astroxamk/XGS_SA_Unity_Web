using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [Header ("Control Buttons")]
    public Button MenuBtn;
    public KeyCode menuKey = KeyCode.Space;

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
    private int desktopScene = 1;
    private int mobileScene = 2;
    Scene scene;

    void Start() { 
        MenuBtn.onClick.AddListener(HandleMainMenuBtn); 
        scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
    }

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
        if (scene.buildIndex <= desktopScene)
            SettingsPc.SetActive(isSettingsViewActive);
        else
            SettingsMobile.SetActive(isSettingsViewActive);

        if (isSettingsViewActive) {
            EnableMouse();

            if (scene.buildIndex == mobileScene)
                settingsLeft.SetActive(true);
            else
                settingsLeft.SetActive(false);
        }
        else
            DisableMouse();

        if (scene.buildIndex <= desktopScene)
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

    public void HandleSeatings() {
        isSeatingActive = !isSeatingActive;
        StairSeatings.SetActive(isSeatingActive);
    }

    public void HandleMainSettingsWindow() {
        RightSettings.SetActive(false);
        RightSettingsMobile.SetActive(false);
        RightSettingsAlternative.SetActive(true);
        RightSettingsAlternativeMobile.SetActive(true);
    }
}
