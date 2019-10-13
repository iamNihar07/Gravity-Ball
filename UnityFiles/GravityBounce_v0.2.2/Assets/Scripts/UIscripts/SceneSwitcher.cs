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
        SceneManager.LoadScene("PracticeMode");
    }

    public void LoadZen()
    {
        SceneManager.LoadScene("Zen");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
