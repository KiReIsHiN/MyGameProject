using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GraphicSettings : MonoBehaviour
{

    [SerializeField]
    private Dropdown _dropDown;




    // Start is called before the first frame update
    void Start()
    {
        _dropDown.ClearOptions();
        _dropDown.AddOptions(QualitySettings.names.ToList());
        _dropDown.value = PlayerPrefs.GetInt("QualityLevel", _dropDown.value);
    }

    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(_dropDown.value);
        PlayerPrefs.SetInt("QualityLevel",_dropDown.value);
    }
    
}
