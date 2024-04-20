using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject projetil;
    [SerializeField] Transform firePoint;
    [SerializeField] float fireRate = .5f;
    float shootCountDown = 0;
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
        Gamepad.current?.SetMotorSpeeds(0f, 0f);

        if (buttonRt > 0.1f || inputManager.GetInteractPressed())
        {
            shootCountDown -= Time.deltaTime;
                Gamepad.current?.SetMotorSpeeds(0f, .5f);
            if (shootCountDown <= 0)
            {
                Instantiate(projetil, firePoint.position, firePoint.rotation);

                shootCountDown = fireRate;

            }
        }

    }
}
