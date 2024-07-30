using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraLocations : MonoBehaviour
{
    [Header("Camera locations")]
    [SerializeField] private Transform XL_cameraAngle;
    [SerializeField] private Transform M_cameraAngle;
    [SerializeField] private Transform S_cameraAngle;
    [SerializeField] private Transform XS_cameraAngle;

    [Header("UI Buttons")]
    [SerializeField] private Button XL_cameraAngleBtn;
    [SerializeField] private Button M_cameraAngleBtn;
    [SerializeField] private Button S_cameraAngleBtn;
    [SerializeField] private Button XS_cameraAngleBtn;

    [Header("Main Camera")]
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Transform PlayerCam;

    Scene scene;

    private void Start()
    {
        scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();

        XL_cameraAngleBtn.onClick.AddListener(() => MoveCamera(XL_cameraAngle));
        M_cameraAngleBtn.onClick.AddListener(() => MoveCamera(M_cameraAngle));
        S_cameraAngleBtn.onClick.AddListener(() => MoveCamera(S_cameraAngle));
        XS_cameraAngleBtn.onClick.AddListener(() => MoveCamera(XS_cameraAngle));

        //if (scene.buildIndex == 1)
        //{
        //    XL_cameraAngleBtn.enabled = false;
        //    M_cameraAngleBtn.enabled = false;
        //    S_cameraAngleBtn.enabled = false;
        //    XS_cameraAngleBtn.enabled = false;
        //}

        XL_cameraAngleBtn.enabled = false;
        M_cameraAngleBtn.enabled = false;
        S_cameraAngleBtn.enabled = false;
        XS_cameraAngleBtn.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainCamera.transform.position = PlayerCam.position;
        }
    }

    void MoveCamera(Transform targetPosition)
    {
        mainCamera.transform.position = targetPosition.position;
    }
}
