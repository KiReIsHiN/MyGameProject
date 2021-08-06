
using UnityEngine;

public class Transformator : MonoBehaviour
{
    public GameObject _transformatorLight;
    public GameObject _light;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _transformatorLight.SetActive(true);
            _light.SetActive(true);
        }
    }
}
