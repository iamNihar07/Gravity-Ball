using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPauser : MonoBehaviour
{
    private GameObject pauseMenuUI, pauseButton, health, coin, coinImage, player;
    private Vector3 velocity;

    private void Start()
    { 
      

      // Prints how many children there are for debugging
      Debug.Log("From MenuPauser.cs script:\nChild Count: " + transform.childCount);

      // Prevents index out of bounds error
      switch (transform.childCount)
      {
        case 1:
              // Gets the first subobject under GamePauser (which should be the pause menu)
              pauseMenuUI = this.transform.GetChild(0).gameObject;
              break;
        case 2:
              pauseMenuUI = this.transform.GetChild(0).gameObject;
              // Gets the second subobject under GamePauser (which shuld be the pause button)
              pauseButton = this.transform.GetChild(1).gameObject;
              break;

        case 3:
              pauseMenuUI = this.transform.GetChild(0).gameObject;
              pauseButton = this.transform.GetChild(1).gameObject;
              health = this.transform.GetChild(2).gameObject;
              break;
        case 5:
              pauseMenuUI = this.transform.GetChild(0).gameObject;
              pauseButton = this.transform.GetChild(1).gameObject;
              health = this.transform.GetChild(2).gameObject;
              coin = this.transform.GetChild(3).gameObject;
              coinImage = this.transform.GetChild(4).gameObject;
              break;
        default:
              break;
      }
      
      
    }

    public void Resume()
    {

      // Re-enables the player's rigidbody and sets the player's velocity back
      player = GameObject.FindWithTag("Player");
      player.GetComponent<Rigidbody2D>().isKinematic = false;
      player.GetComponent<Rigidbody2D>().velocity = velocity;

      //Using timescale would cause the Ball to bug out, so the above code was used instead
      //Time.timeScale = 1f;
      pauseMenuUI.SetActive(false);
      pauseButton.SetActive(true);

      // Checks if the playerhealth object has been connected to the script through the editor's inspector
      // Allows using the same script for both the zen mode and practice mode
      if(health)
      {
        health.SetActive(true);
      }

      // Checks if the scene has coin and coinImage
      if (coin && coinImage)
      {
        coin.SetActive(true);
        coinImage.SetActive(true);
      }

    }

    public void Pause()
    {
      // Gets the player and saves the player's Velocity
      // Then sets the player's velocity to 0 and disables the rigidbody to pause the game
      player = GameObject.FindWithTag("Player");
      velocity = player.GetComponent<Rigidbody2D>().velocity;
      player.GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
      player.GetComponent<Rigidbody2D>().isKinematic = true;

      //Time.timeScale = 0f;

      pauseButton.SetActive(false);
      pauseMenuUI.SetActive(true);
      if(health)
      {
        health.SetActive(false);
      }

      if (coin && coinImage)
      {
        coin.SetActive(false);
        coinImage.SetActive(false);
      }

    }
}
