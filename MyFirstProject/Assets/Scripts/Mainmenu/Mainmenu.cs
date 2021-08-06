using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    public Slider _slider;
    private float _oldValueSound;

    public GameObject _zombie;
    AudioSource _zombieSound;

    private void Start()
    {
        _zombieSound = _zombie.GetComponent<AudioSource>();
        

        _oldValueSound = _slider.value;
        if(!PlayerPrefs.HasKey("SoundValue"))
        {
            _slider.value = 1f;
            _zombieSound.volume = 1f;
        }
    }

    private void Update()
    {
        if (Mathf.Approximately(_oldValueSound, _slider.value))
        {
            PlayerPrefs.SetFloat("SoundValue", _slider.value);
            PlayerPrefs.Save();
            _oldValueSound = _slider.value;
        }

        _zombieSound.volume = PlayerPrefs.GetFloat("SoundValue");
    }



    public void Quit()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    

}
