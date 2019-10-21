using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonTrigger : EventTrigger
{
    private GameObject sceneLoader;
    private GameObject pauseMenu;
    private SceneSwitcher changeScene;
    private MenuPauser pauseOption;

    void Start()
    {
        // Gets the scene loader object 
        // Make sure the SceneLoader has the SceneLoader tag on it
        sceneLoader = GameObject.FindWithTag("SceneLoader");
        // Gets the scene switching script from the scene loader object
        changeScene = sceneLoader.GetComponent(typeof(SceneSwitcher)) as SceneSwitcher;
        // Gets the pauseMenu object
        pauseMenu = GameObject.FindWithTag("gamePauser");

        // If in the main menu, pauseMenu won't exist
        if(pauseMenu)
        {
            // Gets the scene pausing script from the pauseMenu object
            pauseOption = pauseMenu.GetComponent(typeof(MenuPauser)) as MenuPauser;
        }
            

    }

    void changeLevel()
    {
        // Possibly add switch statement here to be used for Arcade Mode Level Select
        // Add input variable with level name
        // use the scene switcher based upon the level
    }
    
    public override void OnPointerClick(PointerEventData data)
    {
        // Call function based on object's name
        Debug.Log("OnPointerClick called.\n"+ 
        "Current object name: '" + this.name + "'\n");
        string scene = SceneManager.GetActiveScene().name;
        switch(this.name)
        {
            case "Start":
                        changeScene.LoadMainMenu();
                        break;
            case "Exit":
                        changeScene.ExitGame();
                        break;
            case "Quit":
                        changeScene.LoadMainMenu();
                        break;
            case "Practice":
                        changeScene.LoadPractice();
                        break;
            case "Zen":
                        changeScene.LoadZen();
                        break;  
            case "Continue":
                        pauseOption.Resume();
                        break;
            case "Settings":
                        Debug.Log("No Option for object '" + this.name + "'.\n" +
                        "Please add Option in ButtonTrigger.cs script.");
                        break;
            case "Help":
                        Debug.Log("No Option for object '" + this.name + "'.\n" +
                        "Please add Option in ButtonTrigger.cs script.");
                        break;
            case "PauseButton":
                        pauseOption.Pause();
                        break;
            case "Arcade":
                        changeScene.LoadTheme1Select();
                        break;
            case "NextLevel":
                if (scene == "1")
                {
                    changeScene.Load_2_1();
                }

                if (scene == "2")
                {
                    Debug.Log("Please add changeScene function in ButtonTrigger.cs to change to level 3\n");
                }
                break;
            case "Back":
                if (scene == "Theme1Select")
                {
                    changeScene.LoadMainMenu();
                }
                if (scene == "Theme2Select")
                {
                    changeScene.LoadMainMenu();
                }

                break;
            
            case "1-1 Image":
                changeScene.Load_1_1();
                break;
            
            case "2-1 Image":
                changeScene.Load_2_1();
                break;
            
            case "NextArrow":
                if (scene == "Theme1Select")
                {
                    changeScene.LoadTheme2Select();
                }

                if (scene == "Theme2Select")
                {
                    Debug.Log("ButtonTrigger.cs\nMissing Load function");
                }
                break;
            
            case "BackArrow":
                if (scene == "Theme2Select")
                {
                    changeScene.LoadTheme1Select();
                }

                break;
                        
            default:
                        Debug.Log("No option for this object. Please add option in ButtonTrigger.cs script.\n");
                        Debug.Log("Option should be added as a switch case statement.");
                        break;
        }
    }
}
