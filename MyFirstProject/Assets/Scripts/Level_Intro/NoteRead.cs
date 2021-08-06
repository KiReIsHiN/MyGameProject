using UnityEngine.UI;
using UnityEngine;

public class NoteRead : MonoBehaviour
{
    public GameObject _cameraMain;
    public GameObject _currentCamera;
    public GameObject _buttonExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _cameraMain.SetActive(false);
            _currentCamera.SetActive(true);
            _buttonExit.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    void Start()
    {
        Button btn = _buttonExit.GetComponent<Button>();
        btn.onClick.AddListener(OnButtonPressed);
    }

    void OnButtonPressed()
    {
        _cameraMain.SetActive(true);
        _currentCamera.SetActive(false);
        _buttonExit.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

}
