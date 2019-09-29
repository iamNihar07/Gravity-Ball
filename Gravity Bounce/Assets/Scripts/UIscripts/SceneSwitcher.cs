using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadPractice()
    {
        //This is a workaround for a bug were you pause the game and go back to the main menu
        //But when you come back to the game, the game is still paused
        Time.timeScale = 1f;
        SceneManager.LoadScene("PracticeMode");
    }

    public void LoadZen()
    {
      //This is a workaround for a bug were you pause the game and go back to the main menu
      //But when you come back to the game, the game is still paused
      Time.timeScale = 1f;
      SceneManager.LoadScene("Zen");
    }

    public void ExitGame()
    {
      Application.Quit();
    }
}
