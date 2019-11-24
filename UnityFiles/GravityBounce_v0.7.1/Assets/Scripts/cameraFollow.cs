using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    private GameObject Player;

    private float smoothSpeed = 0.130f;

    // Update is called once per frame. Fixed Update updates witht the refresh rate of the screen (60 frames per second on most screens)
  void FixedUpdate ()
  {

      
      
      Player = GameObject.FindWithTag("Player");
      
      // just referencing trasnform.<item> references the current object the script is attached to
      //if ()
      
      Vector3 temp = new Vector3(Player.transform.position.x,Player.transform.position.y, transform.position.z);
      Vector3 smoothedPosition = Vector3.Lerp(transform.position, temp, smoothSpeed);
      transform.position = smoothedPosition;


  }
}
