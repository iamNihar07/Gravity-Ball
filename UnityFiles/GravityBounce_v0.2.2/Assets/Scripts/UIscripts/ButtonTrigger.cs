using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
                        Debug.Log("No Option for object '" + this.name + "'.\n" +
                        "Please add Option in ButtonTrigger.cs script.");
                        break;
            default:
                        Debug.Log("No option for this object. Please add option in ButtonTrigger.cs script.\n");
                        Debug.Log("Option should be added as a switch case statement.");
                        break;
        }
    }
}
