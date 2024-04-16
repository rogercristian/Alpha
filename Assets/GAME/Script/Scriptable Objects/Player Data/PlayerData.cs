using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "player", menuName = "ScriptableObject/player")]
public class PlayerData : ScriptableObject
{
    public Sprite playerImage;
    public int id;
    public string playerName;
    public int level;
    public GameObject playerPrefab;
}
