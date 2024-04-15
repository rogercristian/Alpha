using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSkinSelection : MonoBehaviour
{
    [SerializeField] GameObject[] playerSkin;

    private void Start()
    {
        if (PlayerInputManager.instance.playerCount == 1)
        {
            playerSkin[0].SetActive(true);
            playerSkin[1].SetActive(false);
        }
        else if(PlayerInputManager.instance.playerCount == 2)
        {
            playerSkin[0].SetActive(false);
            playerSkin[1].SetActive(true);
        }
    }
}
