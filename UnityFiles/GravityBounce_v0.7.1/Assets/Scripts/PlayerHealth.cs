using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    // The amount of health the player starts the game with.
    private int _playerHealth = 10;
    public void LowerHealth ()
    {
      this._playerHealth --;
    }

    public void RaiseHealth()
    {
      this._playerHealth ++;
    }

    public int GetHealth()
    {
      return this._playerHealth;
    }

}
