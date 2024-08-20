using UnityEngine;

public class UIController_Mobile : UIController
{
    [Header("Control Settings Window")]
    public GameObject LeftSettings;
    public GameObject mobileControls;

    public override void Update() {
        if (Input.GetKeyDown(menuKey))
            HandleMainMenuBtn();
    }

    /// <summary>
    /// A method that handles the main menu button
    /// </summary>
    public override void HandleMainMenuBtn()
    {
        isSettingsViewActive = !isSettingsViewActive;
        if (scene.buildIndex != desktopScene)
            Settings.SetActive(isSettingsViewActive);

        if (isSettingsViewActive) {
            EnableMouse();
            mobileControls.SetActive(!isSettingsViewActive);
        }
        else {
            DisableMouse();
            mobileControls.SetActive(!isSettingsViewActive);
        }

        if (scene.buildIndex <= desktopScene) {
            bool newState = !playerCamera.enabled;
            playerCamera.enabled = newState;
        }

        RightSettings.SetActive(true);
        RightSettingsAlternative.SetActive(false);
        LeftSettings.SetActive(true);
    }
}
