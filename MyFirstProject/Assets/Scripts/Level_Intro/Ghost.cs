using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField]
    private GameObject _ghost;

    private PostProcessVolume _postProcessVolume;
    private Vignette _vignette;

    private void Start()
    {
        SettingsVignette();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Destroy(_ghost);

            Destroy(this.gameObject, 10);

            _postProcessVolume = PostProcessManager.instance.QuickVolume(7, 2, _vignette);
        }
    }

    private void Update()
    {
        _vignette.intensity.value = Mathf.Sin(Time.realtimeSinceStartup);
    }


    private void SettingsVignette()
    {
        _vignette = ScriptableObject.CreateInstance<Vignette>();
        _vignette.enabled.Override(true);
        _vignette.intensity.Override(1);
        _vignette.smoothness.Override(1);
        _vignette.roundness.Override(1);
    }

    

    private void OnDestroy()
    {
        RuntimeUtilities.DestroyVolume(_postProcessVolume, true, true);
    }
}
