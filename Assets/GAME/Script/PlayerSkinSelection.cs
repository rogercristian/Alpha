using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSkinSelection : MonoBehaviour
{
    [SerializeField] GameObject[] playerSkin;
    PlayerInput input;
    private void OnEnable()
    {
        GameEvents.Instance.OnReposition += Handle_OnReposition;
        input = GetComponent<PlayerInput>();
    }
    private void OnDestroy()
    {
        GameEvents.Instance.OnReposition -= Handle_OnReposition;

    }
    private void Handle_OnReposition(int id)
    {
        //PlayerStats playerStats = GetComponentInChildren<PlayerStats>();
        //id = playerStats.PlayerID();
     
       // id = input.playerIndex;
        //if (playerStats != null)
        //{

        //    playerSkin[0].SetActive(false);
        //    playerSkin[1].SetActive(true);
        //}
        if (id == 0)
        {
            playerSkin[0].SetActive(true);
            playerSkin[1].SetActive(false);
        }
        else if (id == 1)
        {
            playerSkin[0].SetActive(false);
            playerSkin[1].SetActive(true);
        }
    }
}
