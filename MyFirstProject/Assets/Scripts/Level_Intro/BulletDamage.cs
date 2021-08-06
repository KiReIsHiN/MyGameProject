using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("My Components/Scripts/Level_Intro/Enemy")]
public class BulletDamage : MonoBehaviour
{
    public Enemy _enemy;
    public int _damage = 25;

    // Start is called before the first frame update
    void Start()
    {
        _enemy = GameObject.FindGameObjectWithTag("zombie").GetComponent<Enemy>(); 
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            _enemy._zombieHP -= _damage;
        }
    }
}
