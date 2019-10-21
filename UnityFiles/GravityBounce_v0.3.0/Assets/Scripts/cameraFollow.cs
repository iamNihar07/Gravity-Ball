using UnityEngine;

public class cameraFollow : MonoBehaviour
{


  // Update is called once per frame. Fixed Update updates witht the refresh rate of the screen (60 frames per second on most screens)
  void FixedUpdate () {
    // just referencing trasnform.<item> references the current object the script is attached to
    Vector3 temp = new Vector3(transform.position.x,transform.position.y,Camera.main.transform.position.z);
    Camera.main.transform.position = temp;

    }
}
