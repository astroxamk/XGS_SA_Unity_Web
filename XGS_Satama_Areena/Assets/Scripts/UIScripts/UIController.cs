using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header ("Control Buttons")]
    public Button MenuBtn;

    // Delete this line from final file
    [Header ("Screen Height for Mobile Settings view")]
    public float ScreenHeight = 720f;

    [Header ("Main Menu Genrals")]
    public GameObject SettingsView;
    public PlayerCam playerCamera;
    public GameObject settingsLeft;

    public bool isSettingsViewActive = false;

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

            if (Screen.height > ScreenHeight)
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
    }

    public void DisableMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void EnableMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
