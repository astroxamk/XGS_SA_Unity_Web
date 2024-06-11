using UnityEngine;
using UnityEngine.UI;

public class HallManager : MonoBehaviour
{
    [Header ("Hall Control Buttons")]
    [SerializeField] private Button extraLargeHall;
    [SerializeField] private Button largeAndExtraSmallHall;
    [SerializeField] private Button multiHallAlt;
    [SerializeField] private Button multiHall;

    [Header("Hall Control Buttons Mobile")]
    [SerializeField] private Button extraLargeHallMobile;
    [SerializeField] private Button largeAndExtraSmallHallMobile;
    [SerializeField] private Button multiHallAltMobile;
    [SerializeField] private Button multiHallMobile;

    [Header("Curtains (Add XS hall curtain)")]
    [SerializeField] private GameObject curtainMediumHallSide;
    [SerializeField] private GameObject curtainSmallHallSide;
    [SerializeField] private GameObject curtainExtraSmallHall;

    private bool mediumHallCurtainIsActive = true;
    private bool smallHallCurtainIsActive = true;

    /// <summary>
    /// In a method call, it is possible to create a list of somethings that can be manipulated using the curly braces {} syntax.
    /// The syntax new[] creates a new array of the type specified in the square brackets [].
    /// </summary>
    private void Start()
    {
        // PC Listeners
        extraLargeHall.onClick.AddListener(() => HandleHall(new[] {curtainSmallHallSide,
            curtainMediumHallSide, curtainExtraSmallHall}, new[] {false, false, false}, 
            "XL Hall"));
        largeAndExtraSmallHall.onClick.AddListener(() => HandleHall(new[] { curtainSmallHallSide,
            curtainMediumHallSide, curtainExtraSmallHall }, new[] { false, false, true }, 
            "XS & L Hall"));
        multiHall.onClick.AddListener(() => HandleHall(new[] { curtainSmallHallSide, 
            curtainMediumHallSide, curtainExtraSmallHall }, new[] { true, true, true }, 
            "XS, S & M Hall"));
        
        // Mobile Listeners
        extraLargeHallMobile.onClick.AddListener(() => HandleHall(new[] {curtainSmallHallSide,
            curtainMediumHallSide, curtainExtraSmallHall}, new[] { false, false, false},
            "XL Hall"));
        largeAndExtraSmallHallMobile.onClick.AddListener(() => HandleHall(new[] { curtainSmallHallSide,
            curtainMediumHallSide, curtainExtraSmallHall }, new[] { false, false, true },
            "XS & L Hall"));
        multiHallMobile.onClick.AddListener(() => HandleHall(new[] { curtainSmallHallSide,
            curtainMediumHallSide, curtainExtraSmallHall }, new[] { true, true, true },
            "XS, S & M Hall"));

        // Alternate Buttons Listeners
        multiHallAlt.onClick.AddListener(ToggleCurtains);
        multiHallAltMobile.onClick.AddListener(ToggleCurtains);

    }

    /// <summary>
    /// A method to handle the hall curtain activation
    /// </summary>
    /// <param name="curtains"> A list of GameObjects that can be manipulated </param>
    /// <param name="states"> A list of boolean states for the GameObjects. 
    /// The key positions refer to each key position in the curtains list </param>
    /// <param name="hallType"> Name of the Hall tat has been activated in the project </param>
    private void HandleHall(GameObject[] curtains, bool[] states, string hallType)
    {
        for (int i = 0; i < curtains.Length; i++)
        {
            curtains[i].SetActive(states[i]);
        }
        Debug.Log(hallType + " activated");
    }

    /// <summary>
    /// The toggle controls to the curtains in the scene
    /// In the Debug.Log you can see a small function called a ternary conditional operator.
    /// it works like this: 
    /// boolean (i.e. isActive) ? (ternary) some true value (i.e. isActive) : (conditional) some false value (i.e. !isActive)
    /// for more here is a link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
    /// </summary>
    private void ToggleCurtains()
    {
        curtainExtraSmallHall.SetActive(true);
        if (curtainMediumHallSide.activeInHierarchy)
        {
            mediumHallCurtainIsActive = false;
            smallHallCurtainIsActive = true;
        }
        else
        {
            mediumHallCurtainIsActive = true;
            smallHallCurtainIsActive = false;
        }

        curtainMediumHallSide.SetActive(mediumHallCurtainIsActive);
        curtainSmallHallSide.SetActive(smallHallCurtainIsActive);
        Debug.Log($"Medium Hall Curtain is {(mediumHallCurtainIsActive ? "active" : "deactive")}");
        Debug.Log($"Small Hall Curtain is {(smallHallCurtainIsActive ? "active" : "deactive")}");
    }
}
