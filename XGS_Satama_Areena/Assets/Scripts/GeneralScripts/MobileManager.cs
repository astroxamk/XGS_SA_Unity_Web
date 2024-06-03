using UnityEngine;

public class MobileManager : MonoBehaviour
{
    public GameObject mobileControls;

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
