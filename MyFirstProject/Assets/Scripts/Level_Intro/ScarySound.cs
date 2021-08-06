
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ScarySound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip clip;
    float volumeScale = 0.5f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat("SoundValue");
    }


    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(clip, volumeScale);
            Destroy(gameObject,6);
        }
    }

}
