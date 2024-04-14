using UnityEngine;
[CreateAssetMenu(fileName = "player", menuName = "ScriptableObjects/player")]
public class PlayerData : ScriptableObject
{
    public int id;
    public string playerName;
    public int level;
    public GameObject playerPrefab;
}
