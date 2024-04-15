using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] PlayerData playerData;
    [SerializeField] string playerName;
    [SerializeField] int playerId;
    [SerializeField] int level;

    private void OnEnable()
    {
        playerId = playerData.id;
        level = playerData.level;
        playerName = playerData.playerName;
    }

    public int PlayerID()
    {
        return playerId;
    }
}
