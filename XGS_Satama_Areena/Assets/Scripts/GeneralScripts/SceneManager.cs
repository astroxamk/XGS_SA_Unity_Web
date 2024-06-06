using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [Header("Scene management buttons")]
    [SerializeField] private Button EmptyScene;
    [SerializeField] private Button ConcertScene;
    [SerializeField] private Button SeminarScene;
    [SerializeField] private Button ExhibitionScene;

    private void Start()
    {
        EmptyScene.onClick.AddListener(HandleEmptyScene);
        ConcertScene.onClick.AddListener(HandleConcertScene);
        SeminarScene.onClick.AddListener(HandleSemiarScene);
        ExhibitionScene.onClick.AddListener(HandleExhibitionScene);
    }

    public void HandleEmptyScene()
    {
        Debug.Log("Empty Scene Enabled");
    }

    public void HandleConcertScene()
    {
        Debug.Log("Concert Scene Enabled");
    }

    public void HandleSemiarScene()
    {
        Debug.Log("Seminar Scene Enabled");
    }

    public void HandleExhibitionScene()
    {
        Debug.Log("Exhibition Scene Enabled");
    }
}
