using UnityEngine;

public class StartController : MonoBehaviour
{
    [Header ("UI Elements")]
    public GameObject languageSelection;
    public GameObject platformSelection;

    public void HandleLanguageButtonPress()
    {
        languageSelection.SetActive(false);
        platformSelection.SetActive(true);
    }

    public void HandlePlatformButtonPress(int scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }
}
