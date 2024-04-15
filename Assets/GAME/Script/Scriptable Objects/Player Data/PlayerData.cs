using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "player", menuName = "ScriptableObjects/player")]
public class PlayerData : ScriptableObject
{
    public Image playerImage;
    public int id;
    public string playerName;
    public int level;
    public GameObject playerPrefab;
}
