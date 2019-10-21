using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
        Debug.Log(path);
        FileStream stream = new FileStream (path, FileMode.Create);

        GameInfo data = new GameInfo(info);

        // Takes the data and formats it into binary
        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static GameInfo LoadInfo ()
    {
        string path = Application.persistentDataPath + "/GameInfo.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream (path, FileMode.Open);

            // Changes from binary to readable format
            formatter.Deserialize(stream);

            // Stores the data in a variable and casts it as a PlayerData object type
            GameInfo data = formatter.Deserialize(stream) as GameInfo;

            // Always need to close the file stream
            stream.Close();

            return data;

        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

}
