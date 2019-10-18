using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameInfo
{
    public int level = 1;
    public long score = 0;
    // Start is called before the first frame update

    public GameInfo (SaveData info)
    {
        level = info.level;
        score = info.score; 
    }

}
