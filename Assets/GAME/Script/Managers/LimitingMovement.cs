using UnityEngine;

public class LimitingMovement : MonoBehaviour
{
    [SerializeField] float minX = 10f;
    [SerializeField] float maxX = 10f;
    [SerializeField] float interpolationTime = 0.005f;

    Vector3 minRect;
    Vector3 maxRect;
    [SerializeField] MovingPlayer[] movingPlayers;
    bool validate = false;
    Camera cam;
    private void OnEnable()
    {
        cam = FindAnyObjectByType<Camera>();

        GameEvents.Instance.OnReposition += Handler_OnReposition;
    }
    private void OnDisable()
    {
        GameEvents.Instance.OnReposition -= Handler_OnReposition;

    }
    private void Handler_OnReposition(int id)
    {
        if (id == 0) return;
        validate = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!validate) return;
        Distancia();
    }

    void Distancia()
    {
        movingPlayers = FindObjectsOfType<MovingPlayer>();
        float screemX = cam.pixelWidth / 100f;
        // Debug.Log(screemX);
        if (movingPlayers.Length - 1 == 0) { return; }
        Vector3 currentPlayer2Pos = movingPlayers[1].transform.position;
        Vector3 currentPlayer1Pos = movingPlayers[0].transform.position;

        // float distance = Vector3.Distance(movingPlayers[0].transform.position, movingPlayers[1].transform.position);
        float distance = Vector3.Distance(new Vector3(currentPlayer1Pos.x, 0, 0),
            new Vector3(currentPlayer2Pos.x, 0, 0));
        // Debug.Log(distance);
        maxX = 10f;
        minX = 10f;
        Rigidbody rb2 = movingPlayers[1].GetComponent<Rigidbody>();
        Rigidbody rb1 = movingPlayers[0].GetComponent<Rigidbody>();

        if (distance >= screemX)
        {

            if (currentPlayer2Pos.x < currentPlayer1Pos.x)
            {
                currentPlayer2Pos.x = Mathf.Lerp(currentPlayer2Pos.x, currentPlayer1Pos.x, interpolationTime);
            }
            else if (currentPlayer2Pos.x > currentPlayer1Pos.x)
            {
                currentPlayer2Pos.x = Mathf.Lerp(currentPlayer2Pos.x, currentPlayer1Pos.x, interpolationTime);
            }

            //   currentPlayer2Pos.x = Mathf.Clamp(movingPlayers[0].transform.position.x, minX, maxX);
            // movingPlayers[1].transform.position = currentPlayer2Pos;

            rb2.transform.position = currentPlayer2Pos;
            rb1.transform.position = currentPlayer1Pos;
        }

    }
}
