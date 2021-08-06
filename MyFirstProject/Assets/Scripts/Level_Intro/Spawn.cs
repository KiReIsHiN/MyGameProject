
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Zombie;
    public Transform EnemyPos;
    private float _repeatRate = 5.0f;
    public int AmountEnemies;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InvokeRepeating(nameof(SpawnEnemies), 1f, _repeatRate);
        }
    }

    public void SpawnEnemies()
    {
        Instantiate(Zombie, EnemyPos.position, EnemyPos.rotation);
        AmountEnemies++;
        if (AmountEnemies >= 25)
        {
            CancelInvoke("SpawnEnemies");
            Destroy(this.gameObject);
        }
    }
}
