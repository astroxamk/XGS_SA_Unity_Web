using UnityEngine;

public class CloseBtnScript : MonoBehaviour
{
    public PlayerCam playerCamera;
    public UIController uiController;
    public PlayerController playerController;
    public GameObject Menu_UI;

    /// <summary>
    /// 
    /// </summary>
    private void OnMouseUpAsButton()
    {
        uiController.DisableMouse();
        playerCamera.enabled = true;
        playerController.enabled = true;
        Menu_UI.SetActive(true);
    }
}
