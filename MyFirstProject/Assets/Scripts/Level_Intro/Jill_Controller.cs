using UnityEngine;
using UnityEngine.AI;

public class Jill_Controller : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    public NavMeshAgent _agent;

    public Animator _anim;

    private float _speedZombie;

    public AudioSource AS;
    public AudioClip AC;

    public Rigidbody[] AllRigidboidies;

    private void Awake()
    {
        for (int i = 0; i < AllRigidboidies.Length; i++)
        {
            AllRigidboidies[i].isKinematic = true;
        }
    }

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.speed = 0f;
        _anim = GetComponent<Animator>();
        _target = GameObject.FindWithTag("Player").transform;
        AS = GetComponent<AudioSource>();
    }

    void Update()
    {
        _agent.SetDestination(_target.position);
        _speedZombie = _agent.speed;
        if (_speedZombie > 0)
        {
            _anim.SetFloat("_speedZombie", _speedZombie);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            _anim.enabled = false;
            for (int i = 0; i < AllRigidboidies.Length; i++)
            {
                AllRigidboidies[i].isKinematic = false;
            }
            Destroy(this.gameObject, 3);
        }
    }


}
