using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private GameObject temp;
    private PlayerHealth health;
    private Text healthText;

    void Update()
    {
      // Gets the UI component to diplay player health
      healthText = this.GetComponent(typeof(Text)) as Text;

      // Player object has a script with the player's health
      temp = GameObject.FindWithTag("Player");
      health = temp.GetComponent(typeof(PlayerHealth)) as PlayerHealth;

      // Update the UI display with the player's current health
      healthText.text = "Health : " + health.getHealth();

      // Resets the scene if the player's health reaches 0
      if(health.getHealth() <= 0)
      {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
      }

    }
}
