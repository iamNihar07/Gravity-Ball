using System.Runtime.CompilerServices;
using UnityEngine;

static class Data
{
    private static int level1Coins = 0;
    private static int level2Coins = 0;
    private static int level3Coins = 0;

    private static bool level1Complete = false;
    private static bool level2Complete = false;

    public static bool coinsCollected()
    {
        int check = level1Coins + level2Coins + level3Coins;
        if (check >= 30)
        {
            return true;
        }
        
        Debug.Log("Coin coint: " + check);

        return false;
    }

    public static void addCoins(int coin, string level)
    {
        if (level == "1")
        {
            if (coin >= level1Coins)
            {
                level1Coins = coin;
            }

            level1Complete = true;
        }

        if (level == "2")
        {
            if (coin >= level2Coins)
            {
                level2Coins = coin;
            }

            level2Complete = true;
        }

        if (level == "3")
        {
            if (coin >= level3Coins)
            {
                level3Coins = coin;
            }
            
        }
        
        Debug.Log("Level1: " + level1Coins + " Level2: " + level2Coins + " Level3: " + level3Coins);
    }

    public static bool levelUnlocked(string level)
    {
        if (level == "1")
        {
            return level1Complete;
        }

        if (level == "2")
        {
            return level2Complete;
        }

        return false;
    }



}
