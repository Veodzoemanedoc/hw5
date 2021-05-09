using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Rigidbody _bullet;
    [SerializeField] private Transform _gunPoint;
    [SerializeField] private int _bulletSpeed = 10;

    private void OnTriggerEnter(Collider other)
    {
        var Player = other.GetComponent<Player>();
        if (Player != null)
        {
            Invoke("MyInvokeFunction", 1);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        var Player = other.GetComponent<Player>();
        if (Player != null)
            CancelInvoke();

    }
    private void MyInvokeFunction()
    {
        Invoke("MyInvokeFunction", 1);
        Rigidbody bulletInstance = Instantiate(_bullet, _gunPoint.position, Quaternion.identity) as Rigidbody;
        bulletInstance.velocity = _gunPoint.forward * _bulletSpeed;

    }
}
