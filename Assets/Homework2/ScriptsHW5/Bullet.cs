using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    private void OnTriggerEnter(Collider other)
    {
        var Player = other.GetComponent<Player>();
        if (Player != null)
        {
            var enemy = other.GetComponent<Health>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }
    }
    private void Awake()
    {
        Destroy(gameObject, 3);
    }



}
