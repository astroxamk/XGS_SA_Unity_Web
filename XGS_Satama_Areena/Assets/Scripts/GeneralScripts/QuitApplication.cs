using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    public void HandleButtonPress()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
