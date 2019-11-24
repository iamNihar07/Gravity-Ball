using UnityEngine;

public class FailedLevel : MonoBehaviour
{
    private GameObject _deathScreen, _gameUi;
    private Vector3 _velocity;

    public void Failed()
    {
        _deathScreen = GameObject.FindWithTag("DeathScreen");
        _gameUi = GameObject.FindWithTag("gamePauser");
        
        _gameUi.SetActive(false);
        _deathScreen.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void healthDroppedToZero()
    {

        // Prevents the player ball from being affected by gravity in the background
        transform.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            
        // Freezes the player's movement
        transform.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            
        // Displays the win screen
        Failed();
        
    }
}
