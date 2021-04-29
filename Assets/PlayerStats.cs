using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PlayerScoreObject", order = 1)]
public class PlayerStats : ScriptableObject
{
    public int Score;

    public string username;

    public void Restart()
    {
        Score = 0;
        username = "";
    }
}
