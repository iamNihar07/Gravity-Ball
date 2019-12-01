using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnRandom : MonoBehaviour
{
    private Vector3 _leftPos, _rightPos, _lowerPos, _higherPos;
    private GameObject _player;
    
    public GameObject[] pool;
    private static float heighCheck;

    private void Start()
    {
        // Generated objects will be a camera's height above the player and will be generated within a camera's max y value and min y value
        // The x boundaries for generation will be between the left and right wall
        _player = GameObject.FindWithTag("Player");
        Vector3 currentPlayerPosition = _player.transform.position;
        
        // Camera values 
        Camera camera = Camera.main;
        float halfHeight = camera.orthographicSize;
        float halfWidth = camera.aspect * halfHeight;
        
        // Gives us the left and right x boundaries
        _leftPos  = GameObject.FindWithTag("LeftBoundary").transform.position;
        _rightPos = GameObject.FindWithTag("RightBoundary").transform.position;
        
        

        float zSet  = _leftPos.z;
        
        for (int i = 0; i < 5; i++)
        {
            float xRand = Random.Range(_leftPos.x, _rightPos.x);
            float yRand = Random.Range(currentPlayerPosition.y + (halfHeight*2), currentPlayerPosition.y+(halfHeight*4));
            Vector3 position = new Vector3(xRand, yRand, zSet);
            int index = Random.Range(0, pool.Length);
            GameObject g = pool[index];
            instantiateObject(position, g);
            
        }
        heighCheck = currentPlayerPosition.y + (halfHeight * 2);
    }

    private void FixedUpdate()
    {
        // Generated objects will be a camera's height above the player and will be generated within a camera's max y value and min y value
        // The x boundaries for generation will be between the left and right wall
        _player = GameObject.FindWithTag("Player");
        Vector3 currentPlayerPosition = _player.transform.position;
        
        // Camera values 
        Camera camera = Camera.main;
        float halfHeight = camera.orthographicSize;
        float halfWidth = camera.aspect * halfHeight;
        
        // Gives us the left and right x boundaries
        _leftPos  = GameObject.FindWithTag("LeftBoundary").transform.position;
        _rightPos = GameObject.FindWithTag("RightBoundary").transform.position;
        
        

        float zSet  = _leftPos.z;
        if (currentPlayerPosition.y > heighCheck)
        {
            heighCheck += halfHeight * 2;
            for (int i = 0; i < 5; i++)
            {
                float xRand = Random.Range(_leftPos.x, _rightPos.x);
                float yRand = Random.Range(currentPlayerPosition.y + (halfHeight * 2),
                    currentPlayerPosition.y + (halfHeight * 4));
                Vector3 position = new Vector3(xRand, yRand, zSet);
                int index = Random.Range(0, pool.Length);
                GameObject g = pool[index];
                instantiateObject(position, g);

            }
        }

    }


    void instantiateObject(Vector3 position, GameObject clone)
    {
        Instantiate(clone, position, clone.transform.rotation);
    }
    
}
