using System;
using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    private GameObject CameraBoundaries;
    private void Start()
    {
        float orthoSize = 0;
        CameraBoundaries = GameObject.FindWithTag("CameraSize");
        if (CameraBoundaries)
        {
            orthoSize = CameraBoundaries.GetComponent<SpriteRenderer>().bounds.size.x * Screen.height / Screen.width *
                        0.5f;
            Camera.main.orthographicSize = orthoSize;
        }

    }
}
