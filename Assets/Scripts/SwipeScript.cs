using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{
    Vector2 startPos, endPos, direction; // touch start position, touch end position, swipe direction
    float touchTimeStart, touchTimeFinish, timeInterval;//to calculate swipe time

    [Range (0.05f, 1f)] // slider for inspector window
    public float throwForce = 0.3f; //to control throw force

    void Update(){
    // if you touch the Screen

      if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {

            // getting touch position and marking time when you touch the screen
            touchTimeStart = Time.time;
            startPos = Input.GetTouch (0).position;

      }

      // if you release your finger
      if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {

            // marking time whenyou release it
            touchTimeFinish = Time.time;

            // calculate swipe time interval
            timeInterval = touchTimeFinish - touchTimeStart;

            // getting release finger position
            endPos = Input.GetTouch (0).position;

            // calculate swipe direction
            direction = startPos - endPos;

            // add force to ball rigidbody depending on swipe time and direction
            GetComponent<Rigidbody2D> ().AddForce (-direction / timeInterval * throwForce);


        }
    }
}
