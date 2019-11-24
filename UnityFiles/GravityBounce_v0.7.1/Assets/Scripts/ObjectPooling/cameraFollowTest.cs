using UnityEngine;
using UnityEngine.Timeline;

public class cameraFollowTest : MonoBehaviour
{
    private GameObject Player;
    private Vector3 _leftPos;
    private Vector3 _rightPos;
    private Vector2 maxXPositions, maxYPositions;
    
    private float smoothSpeed = 0.130f;
    
    
    
    // Update is called once per frame. Fixed Update updates witht the refresh rate of the screen (60 frames per second on most screens)
    void FixedUpdate ()
    {
        _leftPos = GameObject.FindWithTag("LeftBoundary").transform.position;
        _rightPos = GameObject.FindWithTag("RightBoundary").transform.position;

        Camera camera = Camera.main;
        float halfHeight = camera.orthographicSize;
        float halfWidth = camera.aspect * halfHeight;

        // Vector2(minimum x pos, maximum x pos)
        maxXPositions = new Vector2(_leftPos.x + halfWidth, _rightPos.x - halfWidth);
      
        // Vector2(minimum y pos, maximum y pos)
        // maxYPositions = new Vector2(_leftPos.center.y, _rightPos.center.y);
      
      
        Player = GameObject.FindWithTag("Player");
      
        // just referencing trasnform.<item> references the current object the script is attached to
        //if ()
        Vector3 currentPlayerPosition = Player.transform.position;
        
        // This clamps (restricts) the x coordinates to those of the walls
        
        Vector3 targetPosition = new Vector3(Mathf.Clamp(currentPlayerPosition.x, maxXPositions.x, maxXPositions.y), 
            currentPlayerPosition.y, transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        transform.position = smoothedPosition;


    }
}