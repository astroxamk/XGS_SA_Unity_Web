using UnityEngine;

public class MobileManager : MonoBehaviour
{
    public GameObject mobileControls;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="isEnabled"></param>
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
