using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataToSave
{
    public int level;
    public string username;
    public int score;
    public float time;
    public string Difficulty;

    public DataToSave(PlayerStats playerStats)
    {
        level = playerStats.level;
        username = playerStats.username;
        score = playerStats.Score;
        time = playerStats.totalTime;
        Difficulty = playerStats.Difficulty;
    }
}
