using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CutSceneSubtitles : MonoBehaviour
{
    public GameObject Panel;
    public GameObject SubTitles;
    public int WaitTime;

    public AudioSource _souds;

    private void Update()
    {
        _souds.volume = PlayerPrefs.GetFloat("SoundValue");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Panel.SetActive(true);
            SubTitles.SetActive(true);
            StartCoroutine (TheSequence());
            Debug.Log("Subtitles Start");
        }
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(1);
        SubTitles.GetComponent<Text>().text = "Да, я уехал";
        yield return new WaitForSeconds(WaitTime);
        SubTitles.GetComponent<Text>().text = "Я струсил: не стал искать племянницу";
        yield return new WaitForSeconds(WaitTime);
        SubTitles.GetComponent<Text>().text = "Моя жизнь оказалась мне дороже";
        yield return new WaitForSeconds(WaitTime);
        SubTitles.GetComponent<Text>().text = "Я нашел убежище, в котором прятался до конца дней";
        yield return new WaitForSeconds(WaitTime);
        SubTitles.GetComponent<Text>().text = "До конца дней мне было стыдно за то, что я убежал";
        yield return new WaitForSeconds(WaitTime);
        SubTitles.GetComponent<Text>().text = "Конец";
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene(0);
    }
}
