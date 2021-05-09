using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;

    public void Hurt(int damage)
    {
        
        _health -= damage; ;
        print("HP = " + _health);
        if (_health <= 0)
        {
            Die();
            
        }
    }

    public void Heal(int hpup)
    {
        _health += hpup; ;
        print("HP = " + _health);
    }

    private void Die()
    {
        gameObject.SetActive(false);
        
    }
}