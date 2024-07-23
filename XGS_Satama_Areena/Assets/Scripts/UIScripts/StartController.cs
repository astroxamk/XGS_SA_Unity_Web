using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    [Header ("UI Elements")]
    public GameObject languageSelection;
    public GameObject platformSelection;
    public Slider slider;

    public void HandleLanguageButtonPress()
    {
        languageSelection.SetActive(false);
        platformSelection.SetActive(true);
    }

    public void HandlePlatformButtonPress (int scene)
    {
        slider.gameObject.SetActive(true);
        StartCoroutine(LoadAsync(scene));
    }

    IEnumerator LoadAsync(int scene)
    {
        AsyncOperation operation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(scene);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            slider.value = progress;

            yield return null;
        }
    }
}
