using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNote : MonoBehaviour
{
    public GameObject _note;
    public GameObject _myPlayer;
    private Bullet _bulletScript;

    private void Start()
    {
        _bulletScript = _myPlayer.GetComponent<Bullet>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            _note.SetActive(true);
            _bulletScript.enabled = true;
        }
    }
}
