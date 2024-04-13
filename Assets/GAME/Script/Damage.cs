using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour, IDamageable
{
   [SerializeField] private float life = 100f;
   [SerializeField] float damageAmount = 10;
    void ApplyDamage(float amount)
    {
        life -= amount;
        if (life <= 0)
        {
            Die();
        }
    }

    public void TakeDamage()=> ApplyDamage(damageAmount);
   
    void Die()
    {
        Destroy(gameObject);
    }
}
