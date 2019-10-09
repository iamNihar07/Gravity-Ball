using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{


    private int startingHealth = 10;                            // The amount of health the player starts the game with.

    public void lowerHealth ()
    {
      this.startingHealth --;
    }

    public void raiseHealth()
    {
      this.startingHealth ++;
    }

    public int getHealth()
    {
      return this.startingHealth;
    }

}
