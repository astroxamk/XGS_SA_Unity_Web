using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartController : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject StartUI;
    public PlayerCam playerCamera;
    public PlayerController playerController;

    public void HandleButtonPress()
    {
        StartUI.SetActive(false);
        playerCamera.DisableCursor();
        playerCamera.enabled = true;
        playerController.enabled = true;
    }
}
