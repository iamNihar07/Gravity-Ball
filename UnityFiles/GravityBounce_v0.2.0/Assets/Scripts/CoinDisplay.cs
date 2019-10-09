using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    private GameObject temp;
    private PlayerCoins coins;
    public Text coinCount;

    void Update()
    {
      temp = GameObject.FindWithTag("Player");
      coins = temp.GetComponent<PlayerCoins>();
      coinCount.text = "" + coins.getCoinCount();
    }
}
