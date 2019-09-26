using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{


  // Update is called once per frame
  void FixedUpdate () {
    // just referencing trasnform.<item> references the current object the script is attached to
    Vector3 temp = new Vector3(transform.position.x,transform.position.y,Camera.main.transform.position.z);
    Camera.main.transform.position = temp;

    }
}
