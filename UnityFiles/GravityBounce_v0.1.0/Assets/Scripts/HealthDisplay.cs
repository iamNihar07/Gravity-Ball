using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    GameObject temp;
    PlayerHealth health;
    public Text healthText;

    void start()
    {
    }

    void Update()
    {

      temp = GameObject.FindWithTag("Player");
      health = (PlayerHealth) temp.GetComponent(typeof(PlayerHealth));

      healthText.text = "Health : " + health.getHealth();

      // Resets the level if the player's health reaches 0
      if(health.getHealth() <= 0)
      {
        //Scene scene = SceneManager.GetActiveScene();
        //SceneManager.LoadScene(scene.name);
        SceneManager.LoadScene("MainMenu");
      }

      // For testing purposes only
      //If you hold two fingers on the screen and tap the third, raise health
      if (Input.touchCount > 2 && Input.GetTouch (2).phase == TouchPhase.Ended)
      {
        health.raiseHealth();
      }

      // If you hold one inger on the screen and tap the other on the screen, lower health
      else
      {
        if (Input.touchCount > 1 && Input.GetTouch (1).phase == TouchPhase.Ended)
        {
          health.lowerHealth();
        }
      }


    }
}
