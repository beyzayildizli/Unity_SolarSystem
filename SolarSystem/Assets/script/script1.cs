using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class script1 : MonoBehaviour
{
    public Vector3 vec3;
    private float speed = 5.0f;

    void Update()
    {
        transform.Rotate(speed * vec3 * Time.deltaTime);
    }

    public void On_Value_Changed(float value)
    {
        speed = value;
    }
}