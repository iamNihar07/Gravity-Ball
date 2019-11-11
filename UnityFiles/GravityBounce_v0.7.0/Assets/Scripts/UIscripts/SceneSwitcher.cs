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
    
    public void LoadTheme3Select()
    {
        SceneManager.LoadScene("Theme3Select");
    }

    public void LoadTheme4Select()
    {
        SceneManager.LoadScene("Theme4Select");
    }

    public void Load_1()
    {
        SceneManager.LoadScene("1");
    }

    public void Load_2()
    {
        SceneManager.LoadScene("2");
    }

    public void Load_3()
    {
        SceneManager.LoadScene("3");
    }

    public void Load_4()
    {
        SceneManager.LoadScene("4");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void RestartLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
