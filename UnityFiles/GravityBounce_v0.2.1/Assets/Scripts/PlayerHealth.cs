using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    // The amount of health the player starts the game with.
    private int playerHealth = 10;
    public void lowerHealth ()
    {
      this.playerHealth --;
    }

    public void raiseHealth()
    {
      this.playerHealth ++;
    }

    public int getHealth()
    {
      return this.playerHealth;
    }

}
