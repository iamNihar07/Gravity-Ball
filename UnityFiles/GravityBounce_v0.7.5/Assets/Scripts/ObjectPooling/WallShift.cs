using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallShift : MonoBehaviour
{
    
    //private Renderer _renderer;
    private GameObject _player;

    //private Bounds _wallPos;

   // private Vector3 _playerPos;
   // private Vector3 _floorPos;

    //private bool moved = false;
    
    
    //private Vector3 _colliderPosition;
    private Vector3 _shift;
    // Start is called before the first frame update
    void Start()
    {
        /*_renderer = GetComponent<Renderer>();
        
        
        // Get the object size and store it (returns vector with size
        // Possible use this for the actual image, rather than the collider
        _collider = transform.GetComponent<SpriteRenderer>();

        _wallSize = _collider.bounds.size;
        _colliderPosition = _collider.transform.position;
        
        // Prints out size vector
        Debug.Log("Collider Size : " + _wallSize);
        
        // shifts the wall object above or below the previous object 
        _shift.x = _colliderPosition.x;
        _shift.y = _colliderPosition.y - _wallSize.y * 2;
        _shift.z = _colliderPosition.z;
        
        // This changes the position of the object to the new position
        transform.position = _shift;*/

    }
    
    void Update()
    {
        // Get renderer to determine if the object is in the camera view or not
        //_renderer = GetComponent<Renderer>();
        
        // Use player object to get player's x position
        _player = GameObject.FindWithTag("Player");
        Vector3 wallPosition = transform.position;
        _shift.x = wallPosition.x;
        _shift.y = _player.transform.position.y;
        _shift.z = wallPosition.z;
        transform.position = _shift;
        
        
        
        
        
        
        /*// Get floor object, so that walls don't go below the floor
        _floorPos = GameObject.FindWithTag("Floor").transform.GetComponent<BoxCollider2D>().bounds.max;
        
        // Get the object size and store it (returns vector with size
        // Possible use this for the actual image, rather than the collider
        _wallPos = transform.GetComponent<BoxCollider2D>().bounds;

        // Gets the player position and wall position
        _playerPos = _player.transform.GetComponent<CircleCollider2D>().bounds.center;
        
        // Gets the upper y coordinate of the wall object
        float upperYPosition = _wallPos.max.y;
        
        // Gets the upper y coordinate of the wall object
        float lowerYPosition = _wallPos.min.y;
        
        // TODO: Find a way to only have each wall move one at a time, not all at the same time
        // TODO: Possibly have static variable values for each wall
        if(!(_renderer.isVisible) && (_playerPos.y > upperYPosition) && moved == false)
        {
            moved = true;
            Vector3 wallPosition = transform.position;
            // shifts the wall object above the previous object 
            _shift.x = wallPosition.x;
            _shift.y = wallPosition.y + (_wallPos.size.y*2);
            _shift.z = wallPosition.z;
            transform.position = _shift;
        }
        
        else if(!(_renderer.isVisible) && (_playerPos.y < lowerYPosition) && ((lowerYPosition) > _floorPos.y) && moved == false)
        {
            moved = true;
            Vector3 wallPosition = transform.position;
            // shifts the wall object below the previous object 
            _shift.x = wallPosition.x;
            _shift.y = wallPosition.y - (_wallPos.size.y * 2);
            _shift.z = wallPosition.z;
            transform.position = _shift;
        }*/
        
    }
}
