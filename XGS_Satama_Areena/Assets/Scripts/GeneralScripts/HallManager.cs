using UnityEngine;
using UnityEngine.UI;

public class HallManager : MonoBehaviour
{
    [Header ("Hall Control Buttons")]
    [SerializeField] private Button extraLargeHall;
    [SerializeField] private Button largeAndExtraSmallHall;
    [SerializeField] private Button multiHall;

    [Header("Curtains (Add XS hall curtain)")]
    [SerializeField] private GameObject curtainMediumHallSide;
    [SerializeField] private GameObject curtainSmallHallSide;
    //[SerializeField] private GameObject curtainExtraSmallHall;

    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        extraLargeHall.onClick.AddListener(() => HandleHall(new[] {curtainSmallHallSide,
            curtainMediumHallSide/*, curtainExtraSmallHall*/}, new[] {false, false/*, false*/}, 
            "XL Hall"));
        largeAndExtraSmallHall.onClick.AddListener(() => HandleHall(new[] { curtainSmallHallSide,
            curtainMediumHallSide/*, curtainExtraSmallHall*/ }, new[] { false, false/*, true*/ }, 
            "XS & L Hall"));
        multiHall.onClick.AddListener(() => HandleHall(new[] { curtainSmallHallSide, 
            curtainMediumHallSide/*, curtainExtraSmallHall*/ }, new[] { true, true/*, true*/ }, 
            "XS, S & M Hall"));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="curtains"></param>
    /// <param name="states"></param>
    /// <param name="hallType"></param>
    private void HandleHall(GameObject[] curtains, bool[] states, string hallType)
    {
        for (int i = 0; i < curtains.Length; i++)
        {
            curtains[i].SetActive(states[i]);
        }
        Debug.Log(hallType + " activated");
    }
}
