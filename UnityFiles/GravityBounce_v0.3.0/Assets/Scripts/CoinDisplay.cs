using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    private GameObject _temp;
    private PlayerCoins _coins;
    private Text _coinCount;

    void Update()
    {
      // Get the UI component to display coin number
      _coinCount = this.GetComponent(typeof(Text)) as Text;
      _temp = GameObject.FindWithTag("Player");
      _coins = _temp.GetComponent<PlayerCoins>();

      // Update UI with player's current coin count
      // If statement checks that the current object has a text field
      if (_coinCount != null)
      {
          _coinCount.text = "" + _coins.GetCoinCount();
      }
      
    }
}
