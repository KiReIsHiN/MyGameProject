using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class WayToEscape : MonoBehaviour
{
    public GameObject _choisePanel;
    public GameObject _panelDemo;


    public GameObject _buttonYes;
    public GameObject _buttonNo;

    public GameObject _key;
    public Key1 _key1;



    void Start()
    {
        Button btnYes = _buttonYes.GetComponent<Button>();
        btnYes.onClick.AddListener(OnButtonYesPressed);
        Button btnNo = _buttonYes.GetComponent<Button>();
        btnNo.onClick.AddListener(OnButtonNoPressed);
        _key1 = _key.GetComponent<Key1>();
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && _key1.isActive == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            _choisePanel.SetActive(true);
        }
    }

    void OnButtonYesPressed()
    {
        SceneManager.LoadScene(2);
    }

    void OnButtonNoPressed()
    {
        _panelDemo.SetActive(true);
        _choisePanel.SetActive(false);
    }
}