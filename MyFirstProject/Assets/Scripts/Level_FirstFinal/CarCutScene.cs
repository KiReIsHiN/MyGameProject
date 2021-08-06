using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCutScene : MonoBehaviour
{
    public float Speed = 4f;
    // С какой скоростью должен двигаться объект

    void FixedUpdate()
    {
        transform.Translate((Vector3.forward*-1) * Speed * Time.deltaTime);
        // Vector3.в какое направление двигаться объекту
    }

}
