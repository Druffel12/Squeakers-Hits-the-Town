using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Header("Aim Speed")]
    public float speedH;
    public float speedV;

    [Header("Aim Value")]
    public float yaw;
    public float pitch;

    [Header("Aim Restrictions")]
    public float minPitch = -75;
    public float maxPitch = 0;
    public float minYaw = -50;
    public float maxYaw = 50;

    [Header("Cursor")]
    public bool lockCursor = true;
    private bool m_cursorIsLocked = true;

    float ClampAngle(float angle, float from, float to)
    {
        if (angle > 180) angle = 360 - angle;
        angle = Mathf.Clamp(angle, from, to);
        if (angle < 0) angle = 360 + angle;

        return angle;
    }

    void Start()
    {
        speedH = 2.5f;
        speedV = 2.5f;
    }

    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * speedH;
        pitch -= Input.GetAxis("Mouse Y") * speedV;

        pitch = Mathf.Clamp(pitch, minPitch, maxPitch);
        yaw = Mathf.Clamp(yaw, minYaw, maxYaw);

        transform.eulerAngles = new Vector3(pitch /*0*/, yaw, 0);
        //UpdateCursorLock();
    }

    public void SetCursorLock(bool value)
    {
        lockCursor = value;
        if (!lockCursor)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    //public void UpdateCursorLock()
    //{
    //    if (lockCursor)
    //        InternalLockUpdate();
    //}

    //private void InternalLockUpdate()
    //{
    //    if (Input.GetKeyUp(KeyCode.Escape))
    //    {
    //        m_cursorIsLocked = false;
    //    }
    //    else if (Input.GetMouseButtonUp(0))
    //    {
    //        m_cursorIsLocked = true;
    //    }

    //    if (m_cursorIsLocked)
    //    {
    //        Cursor.lockState = CursorLockMode.Locked;
    //        Cursor.visible = false;
    //    }
    //    else if (!m_cursorIsLocked)
    //    {
    //        Cursor.lockState = CursorLockMode.None;
    //        Cursor.visible = true;
    //    }
    //}
}