using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    private GameObject _winMenuUi, _winMenu, _gameUi;
    private Vector3 _velocity;

    public void Win()
    {
        _winMenu = GameObject.FindWithTag("WinMenu");
        _gameUi = GameObject.FindWithTag("gamePauser");
        Debug.Log(_winMenu);
        Debug.Log(_gameUi);
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
