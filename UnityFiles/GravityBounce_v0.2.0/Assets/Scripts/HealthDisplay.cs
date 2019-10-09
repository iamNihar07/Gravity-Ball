using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private GameObject temp;
    private PlayerHealth health;
    public Text healthText;

    void Update()
    {

      temp = GameObject.FindWithTag("Player");
      health = temp.GetComponent(typeof(PlayerHealth)) as PlayerHealth;

      healthText.text = "Health : " + health.getHealth();

      // Resets the scene if the player's health reaches 0
      if(health.getHealth() <= 0)
      {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
      }

    }
}
