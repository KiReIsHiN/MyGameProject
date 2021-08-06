
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject _ghost;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Destroy(_ghost);  
        }
    }
}
