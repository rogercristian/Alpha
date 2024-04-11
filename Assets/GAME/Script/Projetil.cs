using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    Rigidbody body;
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = transform.forward * speed;
        Destroy(gameObject, 1f);
    }
}
