using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public void HandleButtonPress()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
