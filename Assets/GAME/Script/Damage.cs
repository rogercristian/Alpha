using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
   //[SerializeField] private float life = 100f;
   //[SerializeField] float damageAmount = 10;
    [SerializeField] internal HpManager hpManager;

    private void Awake()
    {
        hpManager.OnDie += HpManager_OnDie;
    }
    private void OnDestroy()
    {
        hpManager.OnDie -= HpManager_OnDie;

    }
    private void HpManager_OnDie()
    {
       Destroy(gameObject);
       
    }
    //void ApplyDamage(float amount)
    //{
    //    life -= amount;
    //    if (life <= 0)
    //    {
    //        Die();
    //    }
    //}

    //public void TakeDamage()=> ApplyDamage(damageAmount);

    //void Die()
    //{
    //    Destroy(gameObject);
    //}
}
