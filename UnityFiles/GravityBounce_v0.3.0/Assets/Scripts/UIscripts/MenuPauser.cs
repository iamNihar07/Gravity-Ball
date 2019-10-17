using UnityEngine;

public class MenuPauser : MonoBehaviour
{
    private GameObject _pauseMenuUi, _pauseButton, _health, _coin, _coinImage, _player;
    private Vector3 _velocity;

    private void Start()
    {
      int childCount = transform.childCount; 
      

      // Prints how many children there are for debugging
      Debug.Log("From MenuPauser.cs script:\nChild Count: " + childCount);

      // Prevents index out of bounds error
      switch (childCount)
      {
        case 1:
              // Gets the first subobject under GamePauser (which should be the pause menu)
              _pauseMenuUi = this.transform.GetChild(0).gameObject;
              break;
        case 2:
              _pauseMenuUi = this.transform.GetChild(0).gameObject;
              // Gets the second subobject under GamePauser (which shuld be the pause button)
              _pauseButton = this.transform.GetChild(1).gameObject;
              break;

        case 3:
              _pauseMenuUi = this.transform.GetChild(0).gameObject;
              _pauseButton = this.transform.GetChild(1).gameObject;
              _health = this.transform.GetChild(2).gameObject;
              break;
        case 5:
              _pauseMenuUi = this.transform.GetChild(0).gameObject;
              _pauseButton = this.transform.GetChild(1).gameObject;
              _health = this.transform.GetChild(2).gameObject;
              _coin = this.transform.GetChild(3).gameObject;
              _coinImage = this.transform.GetChild(4).gameObject;
              break;
        default:
              break;
      }
      
      
    }

    public void Resume()
    {

      // Re-enables the player's rigidbody and sets the player's velocity back
      _player = GameObject.FindWithTag("Player");
      _player.GetComponent<Rigidbody2D>().isKinematic = false;
      _player.GetComponent<Rigidbody2D>().velocity = _velocity;

      //Using timescale would cause the Ball to bug out, so the above code was used instead
      //Time.timeScale = 1f;
      _pauseMenuUi.SetActive(false);
      _pauseButton.SetActive(true);

      // Checks if the playerhealth object has been connected to the script through the editor's inspector
      // Allows using the same script for both the zen mode and practice mode
      if(_health)
      {
        _health.SetActive(true);
      }

      // Checks if the scene has coin and coinImage
      if (_coin && _coinImage)
      {
        _coin.SetActive(true);
        _coinImage.SetActive(true);
      }

    }

    public void Pause()
    {
      // Gets the player and saves the player's Velocity
      // Then sets the player's velocity to 0 and disables the rigidbody to pause the game
      _player = GameObject.FindWithTag("Player");
      _velocity = _player.GetComponent<Rigidbody2D>().velocity;
      _player.GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
      _player.GetComponent<Rigidbody2D>().isKinematic = true;

      //Time.timeScale = 0f;

      _pauseButton.SetActive(false);
      _pauseMenuUi.SetActive(true);
      if(_health)
      {
        _health.SetActive(false);
      }

      if (_coin && _coinImage)
      {
        _coin.SetActive(false);
        _coinImage.SetActive(false);
      }

    }
}
