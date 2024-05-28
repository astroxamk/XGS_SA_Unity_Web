using UnityEngine;

public class MobileManager : MonoBehaviour
{
    public GameObject mobileController;
    public MobilePlayerController mobilePlayerController;

    bool mobileIsActive;

    public void EnableMobileControls(bool isEnabled)
    {
        if (isEnabled){
            mobileIsActive = true;
            mobileController.SetActive(mobileIsActive);
            mobilePlayerController.enabled = mobileIsActive;
            Debug.Log("Mobile Controls Enabled");
        }
        else {
            mobileIsActive = false;
            mobileController.SetActive(mobileIsActive);
            mobilePlayerController.enabled = mobileIsActive;
            Debug.Log("Mobile Controls Disabled");
        }
    }
}
