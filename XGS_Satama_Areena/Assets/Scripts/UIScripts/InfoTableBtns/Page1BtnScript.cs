using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page1BtnScript : MonoBehaviour
{
    [Header("Text Fields")]
    public GameObject TextInstructions;
    public GameObject TextContact;
    [Header("Buttons")]
    public GameObject Page2Btn;

    private void OnMouseUpAsButton()
    {
        TextContact.SetActive(false);
        TextInstructions.SetActive(true);
        Page2Btn.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
