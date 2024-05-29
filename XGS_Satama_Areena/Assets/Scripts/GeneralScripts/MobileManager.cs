using UnityEngine;

public class MobileManager : MonoBehaviour
{
    public GameObject mobileControls;

    bool mobileIsActive;

    public void EnableMobileControls(bool isEnabled)
    {
        if (isEnabled){
            mobileControls.SetActive(true);
            Debug.Log("Mobile Controls Enabled");
        }
        else {
            mobileControls.SetActive(false);
            Debug.Log("Mobile Controls Disabled");
        }
    }
}
