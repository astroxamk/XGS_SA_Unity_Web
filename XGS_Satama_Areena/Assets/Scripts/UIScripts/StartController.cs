using UnityEngine;

public class StartController : MonoBehaviour
{
    [Header ("UI Elements")]
    public GameObject StartUI;

    public void HandleButtonPress()
    {
        StartUI.SetActive(false);
    }
}
