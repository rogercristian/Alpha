using UnityEngine;
using UnityEngine.InputSystem;

public class RepositionPlayer : MonoBehaviour
{
    [SerializeField] private int id;
    private void OnEnable()
    {
        //  id = PlayerInputManager.instance.playerCount;
        PlayerStats playerStats = GetComponentInChildren<PlayerStats>();
        PlayerInput input = GetComponent<PlayerInput>();
        id = input.playerIndex;
      //  id = playerStats.PlayerID();
        GameEvents.Instance.Reposition(id);
        GameEvents.Instance.SeekPlayer();
    }

}
