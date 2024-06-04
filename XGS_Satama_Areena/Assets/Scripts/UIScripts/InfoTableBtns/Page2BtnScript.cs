using UnityEngine;

public class Page2BtnScript : MonoBehaviour
{
    [Header("Text Fields")]
    public GameObject TextInstructions;
    public GameObject TextContact;
    [Header("Buttons")]
    public GameObject Page1Btn;

    /// <summary>
    /// 
    /// </summary>
    private void OnMouseUpAsButton()
    {
        TextInstructions.SetActive(false);
        TextContact.SetActive(true);
        Page1Btn.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
