using UnityEngine;

public class SwipeScript : MonoBehaviour
{
    private Vector2 _startPos, _endPos, _direction; // touch start position, touch end position, swipe direction
    private float _touchTimeStart, _touchTimeFinish, _timeInterval;//to calculate swipe time

    //[Range (0.05f, 1f)]
    // 0.2f is good for computer android emulation, but is way too much on an actual phone
    public float throwForce = 0.05f; //to control throw force

    void Update(){
    // if you touch the Screen

      if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {

            // getting touch position and marking time when you touch the screen
            _touchTimeStart = Time.time;
            _startPos = Input.GetTouch (0).position;

      }

      // if you release your finger
      if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {

            // marking time when you release it
            _touchTimeFinish = Time.time;

            // calculate swipe time interval
            _timeInterval = _touchTimeFinish - _touchTimeStart;

            // getting release finger position
            _endPos = Input.GetTouch (0).position;

            // calculate swipe direction
            _direction = _startPos - _endPos;

            // TODO: Use an if statement to check if the velocity is above a certain point.
            // Else, add the force


            GetComponent<Rigidbody2D> ().AddForce (-_direction / _timeInterval * throwForce);
            
      }
    }
}
