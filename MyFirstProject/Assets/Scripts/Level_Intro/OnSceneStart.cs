using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class OnSceneStart : MonoBehaviour
{
    [SerializeField]
    public GameObject _panel;
    [SerializeField]
    public GameObject _subTitles;

    private void Awake()
    {
        _panel.SetActive(true);
        _subTitles.SetActive(true);
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(1);
        _subTitles.GetComponent<Text>().text = "��� ����� ������";
        yield return new WaitForSeconds(3);
        _subTitles.GetComponent<Text>().text = "������� �� � ����?!";
        yield return new WaitForSeconds(3);
        _subTitles.GetComponent<Text>().text = "����� ����� ����� � ����������";
        yield return new WaitForSeconds(3);
        _subTitles.GetComponent<Text>().text = "����� ���������, ��� ��";
        yield return new WaitForSeconds(3);
        _subTitles.GetComponent<Text>().text = "���� ��������� ������� ....";
        yield return new WaitForSeconds(3);
        _subTitles.GetComponent<Text>().text = ".... ��������� ����������";
        yield return new WaitForSeconds(3);
        _panel.SetActive(false);
        _subTitles.SetActive(false);
    }
}
