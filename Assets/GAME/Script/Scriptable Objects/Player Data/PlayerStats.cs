using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] PlayerData playerData;
    [SerializeField] string playerName;
    [SerializeField] int playerId;
    [SerializeField] int level;
    [SerializeField] Sprite sprite;

    private void OnEnable()
    {
        playerId = playerData.id;
        level = playerData.level;
        playerName = playerData.playerName;
        sprite = playerData.playerImage;
    }
    private void OnValidate()
    {
        playerId = playerData.id;
    }
    public int PlayerID()
    {
        return playerId;
    }
    public int Level() { return level; }
    public string PlayerName() { return playerName;}
    public Sprite Sprite() { return sprite;}    

}
