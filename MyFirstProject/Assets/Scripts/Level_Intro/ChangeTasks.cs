
using UnityEngine;


public class ChangeTasks : MonoBehaviour
{
    public GameObject _previousTask;
    public GameObject _nextTask;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _previousTask.SetActive(false);
            _nextTask.SetActive(true);
        }

    }
}
