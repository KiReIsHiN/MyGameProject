
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    private Transform _target;
    NavMeshAgent _agent;

    Animator _anim;

    public int _zombieHP = 100;
    [SerializeField] private float _speedZombie;

    private AudioSource _as;

    
    void Start ()
    {
        _agent = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
        _target = GameObject.FindWithTag("Player").transform;
        _as = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        _agent.SetDestination(_target.position);
        _speedZombie = _agent.speed;
        if (_speedZombie > 0)
        {
            _anim.SetBool("isWalking", true);
        }else { _anim.SetBool("isWalking", false); }

        if (_zombieHP <= 0)
        {
            Destroy(this.gameObject);
        }

        _as.volume = PlayerPrefs.GetFloat("SoundValue");
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _anim.SetBool("isAttack", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _anim.SetBool("isAttack", false);
        }
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if(_anim)
        {
            if(_target != null)
            {
                _anim.SetLookAtWeight(1);
                _anim.SetLookAtPosition(_target.position);
            }
        }
    }

}