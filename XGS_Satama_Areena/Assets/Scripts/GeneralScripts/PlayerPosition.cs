using UnityEngine;
using UnityEngine.UI;

public class PlayerPosition : MonoBehaviour
{
    [Header ("Move Player Buttons")]
    [SerializeField] private Button mediumHallPosition;
    [SerializeField] private Button smallHallPosition;
    [SerializeField] private Button extraSmallHallPosition;

    [Header ("Move Player Buttons Mobile")]
    [SerializeField] private Button mediumHallPositionMobile;
    [SerializeField] private Button smallHallPositionMobile;
    [SerializeField] private Button extraSmallHallPositionMobile;
    
    [Header ("Player Character")]
    [SerializeField] private GameObject playerCharacter;
    
    [Header ("Positions")]
    [SerializeField] private Transform positionMediumHall;
    [SerializeField] private Transform positionSmallHall;
    [SerializeField] private Transform positionExtraSmallHall;

    private CharacterController characterController;

    /// <summary>
    /// the " ()=> " is a lambda expression that allows us to pass a method as a parameter. 
    /// While the AddListener method requires a delegate, the lambda expression allows us to pass a method 
    /// as a parameter without explicitly defining a delegate.
    /// </summary>
    private void Start()
    {
        characterController = playerCharacter.GetComponent<CharacterController>();

        //PC Listeners
        mediumHallPosition.onClick.AddListener(() => MovePlayer(positionMediumHall, "Medium Hall"));
        smallHallPosition.onClick.AddListener(() => MovePlayer(positionSmallHall, "Small Hall"));
        extraSmallHallPosition.onClick.AddListener(() => MovePlayer(positionExtraSmallHall, "XS Hall"));
        
        // Mobile listeners
        mediumHallPositionMobile.onClick.AddListener(() => MovePlayer(positionMediumHall, "Medium Hall"));
        smallHallPositionMobile.onClick.AddListener(() => MovePlayer(positionSmallHall, "Small Hall"));
        extraSmallHallPositionMobile.onClick.AddListener(() => MovePlayer(positionExtraSmallHall, "XS Hall"));
    }

    /// <summary>
    /// A method that moves the player to a specific position in the project set with a set of empty GameObjects.
    /// </summary>
    /// <param name="targetPos">The position in the project determined by the empty GameObjects</param>
    /// <param name="targetName">The name of the area the player has been moved to</param>
    private void MovePlayer(Transform targetPos, string targetName)
    {
        characterController.enabled = false;
        playerCharacter.transform.position = targetPos.position;
        characterController.enabled = true;
        Debug.Log("Moved to: " +  targetName);
    }
}
