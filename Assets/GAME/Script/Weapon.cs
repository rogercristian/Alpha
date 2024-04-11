using UnityEngine;

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
        if (buttonRt > 0.1f || inputManager.GetInteractPressed())
        {
            GameObject go = Instantiate(projetil, projetilTransform.position, projetilTransform.rotation);

        }
    }
}
