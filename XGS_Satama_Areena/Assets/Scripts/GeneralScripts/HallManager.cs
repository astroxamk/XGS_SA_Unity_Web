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
    /// In a method call, it is possible to create a list of somethings that can be manipulated using the curly braces {} syntax.
    /// The syntax new[] creates a new array of the type specified in the square brackets [].
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
    /// A method to handle the hall curtain activation
    /// </summary>
    /// <param name="curtains"> A list of GameObjects that can be manipulated </param>
    /// <param name="states"> A list of boolean states for the GameObjects. The key positions refer to each key position in the curtains list </param>
    /// <param name="hallType"> Name of the Hall tat has been activated in the project </param>
    private void HandleHall(GameObject[] curtains, bool[] states, string hallType)
    {
        for (int i = 0; i < curtains.Length; i++)
        {
            curtains[i].SetActive(states[i]);
        }
        Debug.Log(hallType + " activated");
    }
}
