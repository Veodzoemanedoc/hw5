using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CapsuleController : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private Transform _starget;
    [SerializeField] private float _speed = 1;

    private void OnTriggerStay(Collider other)
    {
        var Player = other.GetComponent<Player>();
        if (Player != null)
        {
            InvokeRepeating("Disable", 1, 0);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        var Player = other.GetComponent<Player>();
        if (Player != null)
            CancelInvoke("Disable");
            Invoke("Enable", 1);
    }
    private void Disable()
    {
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<BonusPoint>().enabled = false;
        Vector3 relativePos = _target.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;

        transform.position = Vector3.MoveTowards(transform.position, _starget.position, _speed * Time.deltaTime);


    }
    private void Enable()
    {
        GetComponent<BonusPoint>().enabled = true;
        GetComponent<NavMeshAgent>().enabled = enabled;
    }


}
