using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    private GameObject _winMenuUi, _winMenu, _gameUi, _player;
    private PlayerCoins _coins;
    private Vector3 _velocity;

    public void Win()
    {
        string scene = SceneManager.GetActiveScene().name;
        _player = GameObject.FindWithTag("Player");
        _winMenu = GameObject.FindWithTag("WinMenu");
        _gameUi = GameObject.FindWithTag("gamePauser");
        

        _coins = _player.GetComponent<PlayerCoins>();
        
        int coins = _coins.GetCoinCount();
        
        Data.addCoins(coins, scene);


        _gameUi.SetActive(false);
        _winMenu.transform.GetChild(0).gameObject.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If player reaches the level goal
        if (collision.gameObject.name == "Ball")
        {
            // Prevents the player ball from being affected by gravity in the background
            collision.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            
            // Freezes the player's movement
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            
            // Displays the win screen
            Win();
            
        }
    }
}
