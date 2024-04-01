using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField] private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    private Vector3 move;
    InputManager inputManager;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        inputManager = GetComponentInParent<InputManager>();     
    }
    
    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        MovingPlayer();

        Jumping();
    }
    void MovingPlayer()
    {
        Vector2 pos = inputManager.GetMoveDirection();
        move = new Vector3(pos.x, 0, pos.y);

        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
    void Jumping()
    {
        // Changes the height position of the player..
        if (inputManager.GetSubmitPressed() && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
