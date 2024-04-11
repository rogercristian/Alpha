using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject projetil;
    [SerializeField] Transform projetilTransform;
    InputManager inputManager;
    // Start is called before the first frame update
    void Start()
    {
        inputManager = GetComponentInParent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float buttonRt = inputManager.GetButtonRtPressed();
        Gamepad.current.SetMotorSpeeds(0f, 0f);

        if (buttonRt > 0.1f || inputManager.GetInteractPressed())
        {
            Gamepad.current.SetMotorSpeeds(0f, .5f);
            GameObject go = Instantiate(projetil, projetilTransform.position, projetilTransform.rotation);

        }

    }
}
