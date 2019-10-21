using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UIElements;

public static class SaveSystem 
{
    public static void SaveInfo (SaveData info)
    {
        // We don't want the player messing with the information
        BinaryFormatter formatter = new BinaryFormatter();

        // Path to save binary info
        // persistentDataPath just gets a path from the OS that isn't going to 
        // suddenly change. 
        string path = Application.persistentDataPath + "/GameInfo.fun";
        Debug.Log("Saving to: " + path);
        FileStream file;


        if (File.Exists(path))
        {
            file = File.OpenWrite(path);
        }
        else
        {
            file = File.Create(path);
        }

        GameInfo data = new GameInfo(info);
        
        formatter.Serialize(file,data);
        
        file.Close();
    }

    public static GameInfo LoadInfo ()
    {
        string path = Application.persistentDataPath + "/GameInfo.fun";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file;
        Debug.Log("Loading from: " + path);
        
        if (File.Exists(path))
        {
            file = File.OpenRead(path);
        }
        else
        {
            Debug.Log("Save file not found in " + path);
            return null;
        }

        GameInfo data = (GameInfo) formatter.Deserialize(file);
        
        file.Close();
        
        return data;
        
    }

}
