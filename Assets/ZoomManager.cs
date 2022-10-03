using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomManager : MonoBehaviour
{
    public float zoomSize = 5;

    public GameObject Cam1;

    void Start()
    { }

    void Update()
    {
        if (Input.GetKey(KeyCode.PageUp))
        {
            zoomSize -= 0.5f;
        }

        if (Input.GetKey(KeyCode.PageDown))
        {
            zoomSize += 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.End))
        {
            Cam1.GetComponent<CameraFollow>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Home))
        {
            Cam1.GetComponent<CameraFollow>().enabled = true;
        }


        GetComponent<Camera>().orthographicSize = zoomSize;
    }
}
