using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTest : MonoBehaviour
{
    private Camera mainCamera;
    private Vector2 screenBounds;

    void Start()
    {
        mainCamera = gameObject.GetComponent<Camera>();
        screenBounds =
            mainCamera.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
        
    }
}
