using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _targetRotation;

    private bool _isOpen = false;

    
    private void Update()
    {
        if (_isOpen && Input.GetKey("e"))
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(_targetRotation), _speed * Time.deltaTime);
    }

    public void Open()
    {
        _isOpen = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Open();
    }

    private void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("Player"))
            _isOpen = false;
    }
}
