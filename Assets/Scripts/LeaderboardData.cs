using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class LeaderboardData
{
    public string firstPlaceUsername;

    public int firstPlaceScore;

    public float firstPlaceTime;

    public string secondPlaceUsername;

    public int secondPlaceScore;

    public float secondPlaceTime;

    public string thirdPlaceUsername;

    public int thirdPlaceScore;

    public float thirdPlaceTime;

    public LeaderboardData(LeaderBoard Leaderboard)
    {
        firstPlaceUsername = Leaderboard.firstPlaceUsername;
        firstPlaceScore = Leaderboard.firstPlaceScore;
        firstPlaceTime = Leaderboard.firstPlaceTime;
        secondPlaceUsername = Leaderboard.secondPlaceUsername;
        secondPlaceScore = Leaderboard.secondPlaceScore;
        secondPlaceTime = Leaderboard.secondPlaceTime;
        thirdPlaceUsername = Leaderboard.thirdPlaceUsername;
        thirdPlaceScore = Leaderboard.thirdPlaceScore;
        thirdPlaceTime = Leaderboard.thirdPlaceTime;
    }
}
