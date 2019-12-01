using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallShift : MonoBehaviour
{
    private GameObject _player;
    private Vector3 _shift;
    
    void Update()
    {
 
        
        // Use player object to get player's x position
        _player = GameObject.FindWithTag("Player");
        Vector3 wallPosition = transform.position;
        
        // Only change the wall's y position with the player's y position, leaving the wall's x position alone.
        // This gives the illusion of an infinite wall as the player moves up and down (the collisions with the wall will still work
        _shift.x = wallPosition.x;
        _shift.y = _player.transform.position.y;
        _shift.z = wallPosition.z;
        transform.position = _shift;
        
        
    }
}
