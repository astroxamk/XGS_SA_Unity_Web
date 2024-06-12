using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    [Header ("Scene management buttons")]
    [SerializeField] private Button InfoScene;
    [SerializeField] private Button ConcertScene;
    [SerializeField] private Button SeminarScene;
    [SerializeField] private Button ExhibitionScene;

    [Header ("Scene management buttons mobile")]
    [SerializeField] private Button InfoSceneMobile;
    [SerializeField] private Button ConcertSceneMobile;
    [SerializeField] private Button SeminarSceneMobile;
    [SerializeField] private Button ExhibitionSceneMobile;

    [Header ("Other variables")]
    [SerializeField] private GameObject HallInformation;

    private void Start()
    {
        // PC Listeners
        InfoScene.onClick.AddListener(HandleInfoScene);
        ConcertScene.onClick.AddListener(HandleConcertScene);
        SeminarScene.onClick.AddListener(HandleSemiarScene);
        ExhibitionScene.onClick.AddListener(HandleExhibitionScene);

        // Mobile listeners
        InfoSceneMobile.onClick.AddListener(HandleInfoScene);
        ConcertSceneMobile.onClick.AddListener(HandleConcertScene);
        SeminarSceneMobile.onClick.AddListener(HandleSemiarScene);
        ExhibitionSceneMobile.onClick.AddListener(HandleExhibitionScene);
    }

    public void HandleInfoScene()
    {
        Debug.Log("Empty Scene Enabled");
        HallInformation.SetActive(true);
    }

    public void HandleConcertScene()
    {
        Debug.Log("Concert Scene Enabled");
        HallInformation.SetActive(false);
    }

    public void HandleSemiarScene()
    {
        Debug.Log("Seminar Scene Enabled");
        HallInformation.SetActive(false);
    }

    public void HandleExhibitionScene()
    {
        Debug.Log("Exhibition Scene Enabled");
        HallInformation.SetActive(false);
    }
}
