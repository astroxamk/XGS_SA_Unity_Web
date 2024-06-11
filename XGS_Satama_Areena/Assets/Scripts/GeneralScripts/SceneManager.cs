using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [Header("Scene management buttons")]
    [SerializeField] private Button EmptyScene;
    [SerializeField] private Button ConcertScene;
    [SerializeField] private Button SeminarScene;
    [SerializeField] private Button ExhibitionScene;

    [Header("Scene management buttons mobile")]
    [SerializeField] private Button EmptySceneMobile;
    [SerializeField] private Button ConcertSceneMobile;
    [SerializeField] private Button SeminarSceneMobile;
    [SerializeField] private Button ExhibitionSceneMobile;

    private void Start()
    {
        // PC Listeners
        EmptyScene.onClick.AddListener(HandleEmptyScene);
        ConcertScene.onClick.AddListener(HandleConcertScene);
        SeminarScene.onClick.AddListener(HandleSemiarScene);
        ExhibitionScene.onClick.AddListener(HandleExhibitionScene);

        // Mobile listeners
        EmptySceneMobile.onClick.AddListener(HandleEmptyScene);
        ConcertSceneMobile.onClick.AddListener(HandleConcertScene);
        SeminarSceneMobile.onClick.AddListener(HandleSemiarScene);
        ExhibitionSceneMobile.onClick.AddListener(HandleExhibitionScene);
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
