
using UnityEngine;

public class PocketLight : MonoBehaviour
{
    [SerializeField] private GameObject _flashlight;
    [SerializeField] private GameObject _playerFlashlight;
    
    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _flashlight.SetActive(false);
            _playerFlashlight.SetActive(true);
        }
    }
}
