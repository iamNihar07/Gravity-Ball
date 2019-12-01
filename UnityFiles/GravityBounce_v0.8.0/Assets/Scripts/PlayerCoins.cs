using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCoins : MonoBehaviour
{

    // The amount of coins the player starts the game with.
    private int _playerCoins = 0;

    public void LowerCoin ()
    {
      // Only subtracts a coin if the player has a coin in the first place
      if (this._playerCoins > 0)
      {
        this._playerCoins --;
      }
    }

    public void RaiseCoin()
    {
      this._playerCoins++;
    }

    public int GetCoinCount()
    {
      return this._playerCoins;
    }

}
