using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    private GameObject temp;
    private PlayerCoins coins;
    private Text coinCount;

    void Update()
    {
      // Get the UI component to display coin number
      coinCount = this.GetComponent(typeof(Text)) as Text;
      temp = GameObject.FindWithTag("Player");
      coins = temp.GetComponent<PlayerCoins>();

      // Update UI with player's current coin count
      coinCount.text = "" + coins.getCoinCount();
    }
}
