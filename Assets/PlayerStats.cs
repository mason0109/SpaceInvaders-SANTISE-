using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PlayerScoreObject", order = 1)]
public class PlayerStats : ScriptableObject
{
    public int Score;

    public string username;

    public int playerLives;

    public string Difficulty;

    public float totalTime;

    public int level;

    public void Restart()
    {
        Score = 0;
        username = "";
        Difficulty = "Easy";
        playerLives = 3;
        level = 0;
    }
}
