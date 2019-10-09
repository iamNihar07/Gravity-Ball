using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerCoins>())
        {
            // Raises the player's coin coun by 1
            collision.GetComponent<PlayerCoins>().raiseCoin();

            // Checks if the object has an audio source attached and plays it 
            // On collision if it does
            if(gameObject.GetComponent<AudioSource>())
            {
                // Translates the object far far away to be deleted after 3 seconds
                // This allows the sound to play before object deletion (which deletes the audio source)
                gameObject.transform.Translate(1000,1000,1000);

                // Plays the Audio Source attached to the object
                gameObject.GetComponent<AudioSource>().Play();
            }

            // Removes the object on collision after 3 seconds
            Destroy(gameObject, 3);
        }
    }
}
