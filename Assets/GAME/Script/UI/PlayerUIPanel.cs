using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIPanel : MonoBehaviour
{
    [SerializeField] TMP_Text playerName;
   // [SerializeField] PlayerData playerData;
    PlayerStats playerStats;
    [SerializeField] TMP_Text level;
    [SerializeField] Image photo;
    MovingPlayer movingPlayer;
    
    public void AssignPlayer(int index)
    {
        StartCoroutine(AssignPlayerDelay(index));
    }

   IEnumerator AssignPlayerDelay(int index)
    {
       yield return new WaitForSeconds(0.01f);
        movingPlayer = ManualPlayerJoin.instance.playerList[index].GetComponent<PlayerInputHandler>().GetMovingPlayer();
        playerStats = ManualPlayerJoin.instance.playerList[index].GetComponent<PlayerInputHandler>().GetComponentInChildren<PlayerStats>();
 
        print(movingPlayer.name);
        SetUpInfoPanel();
    }

    private void SetUpInfoPanel()
    {
        if(movingPlayer != null)
        {
            //score
            // level
            level.text = playerStats.Level().ToString();
            //name
            playerName.text = playerStats.PlayerName();
            //foto
            photo.sprite = playerStats.Sprite();
        }
    }
}
