using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private GameObject _temp;
    private PlayerHealth _health;
    private Text _healthText;

    private void Update()
    {
      // Gets the UI component to diplay player health
      _healthText = this.GetComponent(typeof(Text)) as Text;

      // Player object has a script with the player's health
      _temp = GameObject.FindWithTag("Player");
      _health = _temp.GetComponent(typeof(PlayerHealth)) as PlayerHealth;

      // Update the UI display with the player's current health
      // If statement is to make sure neither component returned null
      if (_healthText != null && _health != null)
      {
          _healthText.text = "Health : " + _health.GetHealth();
      }

      // Display game over screen if player's heath reaches zero'
      if(_health != null &&_health.GetHealth() <= 0)
      {
          _temp.GetComponent<FailedLevel>().healthDroppedToZero();
      }

    }
}
