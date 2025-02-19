using UnityEngine;

public class Projetil : MonoBehaviour
{
    Rigidbody body;
    [SerializeField] float speed = 10f;
    [SerializeField] int damageAmout = 5;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
       // body.velocity = transform.forward * speed;
       body.AddForce(transform.forward * speed , ForceMode.Impulse);
        Destroy(gameObject, .5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Damage>(out var damage))
        {
            damage.hpManager.TakeDamage(damageAmout);
        }
            Destroy(gameObject);
    }


}
