
using UnityEngine;

public class Jill_Instantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject _jill;
    [SerializeField]
    private GameObject _jillTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Instantiate(_jill,new Vector3(2.14f, 0f, 5.27f), Quaternion.Euler(0f,90f,0f));
            Instantiate(_jillTrigger, new Vector3(14.55f, 0f, 4.7544f), Quaternion.identity);
        }
    }
}
