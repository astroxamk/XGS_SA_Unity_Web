using UnityEngine;

public class Page1BtnScript : MonoBehaviour
{
    [Header("Text Fields")]
    public GameObject TextInstructions;
    public GameObject TextContact;
    [Header("Buttons")]
    public GameObject Page2Btn;

    /// <summary>
    /// OnMouseUpAsButton allows for a 3D object to be clicked on and perform an action. This is used to switch 
    /// between pages in the info table.
    /// </summary>
    private void OnMouseUpAsButton()
    {
        TextContact.SetActive(false);
        TextInstructions.SetActive(true);
        Page2Btn.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
