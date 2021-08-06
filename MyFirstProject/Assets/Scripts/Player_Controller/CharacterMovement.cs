using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CharacterMovement : MonoBehaviour
{
    public static CharacterMovement Player { get; private set; }

    public int _healthPower = 100;
    public Slider _slider;

    Animator _anim;

    public int _speedWalk;
    public int _sprintSpeed;
    private int _baseSpeed = 0;

    Rigidbody rb;
    float _horizontal;
    float _vertical;
    private Vector3 _dir;

    public GameObject _weapon;

    private void Awake()
    {
        if (Player == null)
        {
            Player = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move();

        _slider.value = _healthPower;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _baseSpeed = _speedWalk + _sprintSpeed;
        }
        else
        {
            _baseSpeed = _speedWalk;
        }

        if(_healthPower <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    void Move ()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        _anim.SetFloat("vertical", _vertical);
        _anim.SetFloat("horizontal", _horizontal);


        Vector3 dir = transform.right*_horizontal + transform.forward*_vertical;
        dir *= _baseSpeed;
        dir.y = rb.velocity.y;

        rb.velocity = dir;

        if (_weapon.activeSelf == true)
        {
            _anim.SetTrigger("isAiming");
        }
    }

}
