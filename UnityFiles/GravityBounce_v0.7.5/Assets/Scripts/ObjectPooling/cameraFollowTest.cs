using UnityEngine;
using UnityEngine.Timeline;

public class cameraFollowTest : MonoBehaviour
{
    private GameObject Player;
    private Vector3 _leftPos, _rightPos, _lowerPos;
    private GameObject _higherPos;
    private Vector2 maxXPositions, maxYPositions;
    
    private float smoothSpeed = 0.130f;
    
    
    
    // Update is called once per frame. Fixed Update updates witht the refresh rate of the screen (60 frames per second on most screens)
    void FixedUpdate ()
    {
        _leftPos = GameObject.FindWithTag("LeftBoundary").transform.position;
        _rightPos = GameObject.FindWithTag("RightBoundary").transform.position;
        _lowerPos = GameObject.FindWithTag("Floor").transform.position;
        _higherPos = GameObject.FindWithTag("Ceiling");
        

        Camera camera = Camera.main;
        float halfHeight = camera.orthographicSize;
        float halfWidth = camera.aspect * halfHeight;

        // Vector2(minimum x pos, maximum x pos)
        maxXPositions = new Vector2(_leftPos.x + halfWidth, _rightPos.x - halfWidth);
        if (_higherPos != null)
        {
            maxYPositions = new Vector2(_lowerPos.y + halfHeight, _higherPos.transform.position.y - halfHeight);
        }

        // Vector2(minimum y pos, maximum y pos)
        // maxYPositions = new Vector2(_leftPos.center.y, _rightPos.center.y);
      
      
        Player = GameObject.FindWithTag("Player");
      
        // just referencing trasnform.<item> references the current object the script is attached to
        //if ()
        Vector3 currentPlayerPosition = Player.transform.position;
        
        // This clamps (restricts) the x coordinates to those of the walls
        if (_higherPos == null)
        {
            
            Vector3 targetPosition = new Vector3(Mathf.Clamp(currentPlayerPosition.x, maxXPositions.x, maxXPositions.y), 
                Mathf.Clamp(currentPlayerPosition.y, Mathf.Min(currentPlayerPosition.y + halfHeight, _lowerPos.y + halfHeight), Mathf.Max(currentPlayerPosition.y, currentPlayerPosition.y)), transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
        if (_higherPos != null)
        {
            Vector3 targetPosition = new Vector3(Mathf.Clamp(currentPlayerPosition.x, maxXPositions.x, maxXPositions.y), 
                Mathf.Clamp(currentPlayerPosition.y, maxYPositions.x, maxYPositions.y), transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
        


    }
}