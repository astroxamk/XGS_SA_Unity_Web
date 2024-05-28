using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header ("Control Buttons")]
    public Button MenuBtn;

    [Header ("Main Menu Genrals")]
    public GameObject SettingsView;
    public PlayerCam playerCamera;
    public PlayerController playerController;
    public GameObject settingsLeft;

    private bool isSettingsViewActive = false;

    void Start()
    {
        MenuBtn.onClick.AddListener(HandleMainMenuBtn);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HandleMainMenuBtn();
        }
    }

    void HandleMainMenuBtn()
    {
        isSettingsViewActive = !isSettingsViewActive;
        SettingsView.SetActive(isSettingsViewActive);

        if(isSettingsViewActive)
        {
            EnableMouse();

            if (Screen.height > 719f)
            {
                settingsLeft.SetActive(true);
            }
            else
            {
                settingsLeft.SetActive(false);
            }
        }
        else
        {
            DisableMouse();
        }

        bool newState = !playerCamera.enabled;
        playerCamera.enabled = newState;
        playerController.enabled = newState;
    }

    void DisableMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void EnableMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
