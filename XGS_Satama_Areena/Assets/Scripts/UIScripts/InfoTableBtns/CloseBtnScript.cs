using UnityEngine;

public class CloseBtnScript : MonoBehaviour
{
    public PlayerCam playerCamera;
    public UIController uiController;
    public PlayerController playerController;
    public GameObject Menu_UI;

    /// <summary>
    /// OnMouseUpAsButton allows for a 3D object to be clicked on and perform an action. This is used to close
    /// the info table and allow for the player to move around the project.
    /// </summary>
    private void OnMouseUpAsButton() {
        uiController.DisableMouse();
        playerCamera.enabled = true;
        playerController.enabled = true;
        Menu_UI.SetActive(true);
    }
}
