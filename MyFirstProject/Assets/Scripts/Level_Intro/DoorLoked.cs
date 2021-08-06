
using UnityEngine;

public class DoorLoked : MonoBehaviour
{
    public GameObject _key;
    public Key1 _key1;

    

    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _targetRotation;
    private bool _isOpen = false;

    private void Start ()
    {
        _key1 = _key.GetComponent<Key1>();
    }
    private void Update()
    {
        if (_isOpen)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(_targetRotation), _speed * Time.deltaTime);
    }

    public void Open()
    {
        _isOpen = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && _key1.isActive == true)
            Open();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            _isOpen = false;
    }


}
