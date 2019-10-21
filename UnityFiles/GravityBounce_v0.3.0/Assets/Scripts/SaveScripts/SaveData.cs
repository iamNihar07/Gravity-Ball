using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{  
    // Default level open of 1
    public int level = 1;

    // Default score of 0
    public long score = 0;

    private void Start() 
    {
       this.SaveInfo();    
        
    }

    // Going to take in the player script. In this case, it's just called Player
    public void SaveInfo ()
    {
        SaveSystem.SaveInfo(this);
    }

    public void LoadInfo ()
    {
        GameInfo data = SaveSystem.LoadInfo();

        // Might not have initial save
        if (data != null)
        {
            level = data.level;
            score = data.score;
            // Return 1 when finished
            return;
        }
        else
        {
            // Return 0 if an error occured
            return;
        }
        
    }
}
