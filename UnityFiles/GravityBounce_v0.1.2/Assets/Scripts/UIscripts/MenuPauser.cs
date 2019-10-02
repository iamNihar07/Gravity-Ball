﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPauser : MonoBehaviour
{
    //Made public in order to connect objects to the script through the unity editor's inspector
    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public GameObject health;

    //Made private because player object can be obtained through the FindWithTag function
    private GameObject player;
    private Vector3 velocity;

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

    }
}
