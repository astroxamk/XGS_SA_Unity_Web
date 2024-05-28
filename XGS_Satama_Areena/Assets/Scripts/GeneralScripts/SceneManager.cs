using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Vector3 basePosition = new Vector3(136.84, 47.65298, -180.67)
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

    public void HandleXL_Hall()
    {
        Debug.Log("Extra Large Hall Enabled");
    }

    public void HandleXS_L_Hall()
    {
        Debug.Log("XS and Large Hall Enabled");
    }

    public void HandleXS_M_S_Hall()
    {
        Debug.Log("XS, Medium and Small Hall Enabled");
    }

    public void HandleMoveTo_M_Hall()
    {
        Debug.Log("Moved to: Medium Hall");
        // Vector3 position = new Vector3(108, 47.65298, -4)
    }

    public void HandleMoveTo_S_Hall()
    {
        Debug.Log("Moved to: Small Hall");
        // Vector3 position = new Vector3(-124, 47.65298, -4)
    }

    public void HandleMoveTo_XS_Hall()
    {
        Debug.Log("Moved to: XS Hall");
        // Vector3 position = new Vector3(-276, 92.52679, -4)
    }
}
