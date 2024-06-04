using UnityEngine;
using UnityEngine.UI;

public class PlayerPosition : MonoBehaviour
{
    [Header("Move Player Buttons")]
    [SerializeField] private Button mediumHallPosition;
    [SerializeField] private Button smallHallPosition;
    [SerializeField] private Button extraSmallHallPosition;
    
    [Header("Player Character")]
    [SerializeField] private GameObject playerCharacter;
    
    [Header("Positions")]
    [SerializeField] private Transform positionMediumHall;
    [SerializeField] private Transform positionSmallHall;
    [SerializeField] private Transform positionExtraSmallHall;

    private CharacterController characterController;

    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        characterController = playerCharacter.GetComponent<CharacterController>();

        mediumHallPosition.onClick.AddListener(() => MovePlayer(positionMediumHall, "Medium Hall"));
        smallHallPosition.onClick.AddListener(() => MovePlayer(positionSmallHall, "Small Hall"));
        extraSmallHallPosition.onClick.AddListener(() => MovePlayer(positionExtraSmallHall, "XS Hall"));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="targetPos"></param>
    /// <param name="targetName"></param>
    private void MovePlayer(Transform targetPos, string targetName)
    {
        characterController.enabled = false;
        playerCharacter.transform.position = targetPos.position;
        characterController.enabled = true;
        Debug.Log("Moved to: " +  targetName);
    }
}
