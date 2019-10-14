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

    public void LoadTheme1Select()
    {
        SceneManager.LoadScene("Theme1Select");
    }

    public void LoadTheme2Select()
    {
        SceneManager.LoadScene("Theme2Select");
    }

    public void Load_1_1()
    {
        SceneManager.LoadScene("1-1");
    }

    public void Load_2_1()
    {
        SceneManager.LoadScene("2-1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
