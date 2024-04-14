using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] PlayerData playerData;
    [SerializeField] string playerName;
    [SerializeField] int playerId;
    [SerializeField] int level;
    [SerializeField] GameObject[] playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.Instance.OnSelectSkin += Handler_OnSelectSkin;

    }
    private void OnDestroy()
    {
        GameEvents.Instance.OnSelectSkin -= Handler_OnSelectSkin;

    }
    private void Handler_OnSelectSkin()
    {
        UpdatePlayerStats();

        if (playerId == 1)
        {
            playerPrefab[0].SetActive(true);
            playerPrefab[1].SetActive(false);

        }
        else if (playerId == 2)
        {
            playerPrefab[0].SetActive(false);
            playerPrefab[1].SetActive(true);
        }

    }

    private void OnValidate()
    {
        if (playerData == null) return;
        GameEvents.Instance.SelectSkin();

    }
    private void OnEnable()
    {
        GameEvents.Instance.SelectSkin();

    }
    // Update is called once per frame
    public void UpdatePlayerStats()
    {
        playerId = playerData.id;
        level = playerData.level;
        playerName = playerData.playerName;

    }
}
