
using UnityEngine;

public class CameraOrbitScript : MonoBehaviour
{

    public float lookSensitivity;
    public float minXLook;
    public float maxXLook;
    public Transform camAnchor;

    public bool invertXRotation;

    private float curXRot;

    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        //Rotate player horizontal
        transform.eulerAngles += Vector3.up * x * lookSensitivity;

        if(invertXRotation)
        {
            curXRot += y * lookSensitivity;
        }
        else
        {
            curXRot -= y * lookSensitivity;
        }

        curXRot = Mathf.Clamp(curXRot,minXLook,maxXLook);

        Vector3 clampedAngle = camAnchor.eulerAngles;
        clampedAngle.x = curXRot;

        camAnchor.eulerAngles = clampedAngle;
    }

}
