using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLeaderboard : MonoBehaviour
{

    [SerializeField]
    private LeaderBoard Leaderboard; 

    [SerializeField]
    private PlayerStats PlayerStats;

    // Start is called before the first frame update
    void Start()
    {
        updateScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScores()
    {
        if (PlayerStats.Score > Leaderboard.firstPlaceScore)
        {
            Leaderboard.secondPlaceUsername = Leaderboard.firstPlaceUsername;
            Leaderboard.secondPlaceScore = Leaderboard.firstPlaceScore;
            Leaderboard.secondPlaceTime = Leaderboard.firstPlaceTime;
            Leaderboard.firstPlaceUsername = PlayerStats.username;
            Leaderboard.firstPlaceScore = PlayerStats.Score;
            Leaderboard.firstPlaceTime = PlayerStats.totalTime;
        } else if (PlayerStats.Score < Leaderboard.firstPlaceScore && PlayerStats.Score > Leaderboard.secondPlaceScore)
        {
            Leaderboard.thirdPlaceUsername = Leaderboard.secondPlaceUsername;
            Leaderboard.thirdPlaceScore = Leaderboard.secondPlaceScore;
            Leaderboard.thirdPlaceTime = Leaderboard.secondPlaceTime;
            Leaderboard.secondPlaceUsername = PlayerStats.username;
            Leaderboard.secondPlaceScore = PlayerStats.Score;
            Leaderboard.secondPlaceTime = PlayerStats.totalTime;
        } else if (PlayerStats.Score < Leaderboard.secondPlaceScore && PlayerStats.Score > Leaderboard.thirdPlaceScore)
        {
            Leaderboard.thirdPlaceUsername = PlayerStats.username;
            Leaderboard.thirdPlaceScore = PlayerStats.Score;
            Leaderboard.thirdPlaceTime = PlayerStats.totalTime;
        }
    }
}
