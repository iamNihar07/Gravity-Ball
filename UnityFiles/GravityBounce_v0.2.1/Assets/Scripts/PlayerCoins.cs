using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCoins : MonoBehaviour
{

    // The amount of coins the player starts the game with.
    private int playerCoins = 0;

    public void lowerCoin ()
    {
      // Only subtracts a coin if the player has a coin in the first place
      if (this.playerCoins > 0)
      {
        this.playerCoins --;
      }
    }

    public void raiseCoin()
    {
      this.playerCoins++;
    }

    public int getCoinCount()
    {
      return this.playerCoins;
    }

}
