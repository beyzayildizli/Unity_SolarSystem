using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;

    private Camera[] cameras;
    private int activeCameraIndex = 0;

    void Start()
    {
        cameras = new Camera[] { camera1, camera2, camera3 };
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cameras[activeCameraIndex].enabled = false;
            activeCameraIndex = (activeCameraIndex + 1) % cameras.Length;
            cameras[activeCameraIndex].enabled = true;
        }
    }
}
