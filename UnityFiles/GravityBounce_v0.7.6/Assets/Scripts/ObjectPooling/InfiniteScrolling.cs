using UnityEngine;  
using System.Linq;  
using System.Collections.Generic;  
 
public class InfiniteScrolling : MonoBehaviour  
{  
    public float speed;  
    private List<Transform> backgroundPart;  
    void Start()  
    {  
        backgroundPart = new List<Transform>();  
        for (int i = 0; i < transform.childCount; i++)  
        {  
            Transform child = transform.GetChild(i);  
            if (child.GetComponent<Renderer>() != null)  
            {  
                backgroundPart.Add(child);  
            }  
        }  
        backgroundPart = backgroundPart.OrderBy ( t => t.position.y ) .ToList();  
    }  
    void Update()  
    {  
        transform.Translate (Vector2.up * Time.deltaTime * speed);  
        Transform firstChild = backgroundPart.FirstOrDefault();  
        if (firstChild != null)  
        {  
            if (firstChild.position.y > Camera.main.transform.position.y)  
            {  
                if (firstChild.GetComponent<Renderer>().IsVisibleFrom(Camera.main) == false) 
                {  
                    Transform lastChild = backgroundPart.LastOrDefault();    
                    Vector3 lastPosition = lastChild.transform.position;  
                    Vector3 lastSize = ( lastChild.GetComponent<Renderer>().bounds.max - lastChild.GetComponent<Renderer>().bounds.min );  
                    firstChild.position = new Vector3(firstChild.position.x, lastPosition.y + lastSize.y, firstChild.position.z);    
                    backgroundPart.Remove(firstChild);  
                    backgroundPart.Add( firstChild );  
                }  
            }  
        }  
    }  
} 
