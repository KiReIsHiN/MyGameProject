using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCutScene : MonoBehaviour
{
    public float Speed = 4f;
    // � ����� ��������� ������ ��������� ������

    void FixedUpdate()
    {
        transform.Translate((Vector3.forward*-1) * Speed * Time.deltaTime);
        // Vector3.� ����� ����������� ��������� �������
    }

}
