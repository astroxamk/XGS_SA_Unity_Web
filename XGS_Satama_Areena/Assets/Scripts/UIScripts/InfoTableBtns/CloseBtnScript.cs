using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBtnScript : MonoBehaviour
{
    public PlayerCam playerCamera;
    public PlayerController playerController;
    public GameObject Menu_UI;

    private void OnMouseUpAsButton()
    {
        playerCamera.DisableCursor();
        playerCamera.enabled = true;
        playerController.enabled = true;
        Menu_UI.SetActive(true);
    }
}
