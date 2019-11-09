using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallShift : MonoBehaviour
{
    private Collider2D collider;

    Vector3 m_Size;

    Vector3 shift;
    // Start is called before the first frame update
    void Start()
    {
        // Get the object size and store it (returns vector with size
        // Possible use this for the actual image, rather than the collider
        collider = transform.GetComponent<Collider2D>();
        m_Size = collider.bounds.size;
        
        // Prints out size vector
        Debug.Log("Collider Size : " + m_Size);
        
        // shifts the wall object above or below the previous object 
        shift.x = collider.transform.position.x;
        shift.y = collider.transform.position.y - m_Size.y * 2;
        shift.z = collider.transform.position.z;
        
        // This changes the position of the object to the new position
        transform.position = shift;

    }
    
    void Update()
    {
        
    }
}
