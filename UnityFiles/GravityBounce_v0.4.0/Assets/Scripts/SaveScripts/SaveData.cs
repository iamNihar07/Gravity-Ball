using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveData : MonoBehaviour
{  
    // Default level open of 1
    public int level = 1;

    // Default score of 0
    public long score = 0;

    public Dictionary<string, int> coins = new Dictionary<string, int>();
    

    private void Start()
    { 
        // Default value for saving
        coins.Add("1", 0);
        
        if (LoadInfo() != 1)
        {
            SaveInfo(); 
        }
        else
        {
            Debug.Log("Load Save Data Succeeded!");
        }
          
        
    }

    // Going to take in the player script. In this case, it's just called Player
    public void SaveInfo ()
    {
        SaveSystem.SaveInfo(this);
    }

    public int LoadInfo ()
    {
        GameInfo data = SaveSystem.LoadInfo();

        // Might not have initial save
        if (data != null)
        {
            level = data.level;
            score = data.score;
            coins = data.coins;
            // Return 1 when finished
            return 1;
        }

        return 0;

    }
}
