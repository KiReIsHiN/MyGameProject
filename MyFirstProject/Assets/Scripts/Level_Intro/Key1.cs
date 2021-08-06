
using UnityEngine;

public class Key1 : MonoBehaviour
{
    public bool isActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActive = true;
            Debug.Log("Key is found");
            gameObject.SetActive(false);
        }
    }

}
