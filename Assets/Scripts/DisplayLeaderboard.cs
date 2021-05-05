using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLeaderboard : MonoBehaviour
{

    [SerializeField]
    private Text firstplace;

    [SerializeField]
    private Text secondplace;

    [SerializeField]
    private Text thirdplace;

    [SerializeField]
    private LeaderBoard Leaderboard;

    // Start is called before the first frame update
    void Start()
    {
        displayScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void displayScores()
    {
        LeaderboardData leaderboard = SaveSystem.LoadLeaderboard();
        firstplace.text = leaderboard.firstPlaceUsername + ": " + leaderboard.firstPlaceScore + " Time: " + leaderboard.firstPlaceTime;
        secondplace.text = leaderboard.secondPlaceUsername + ": " + leaderboard.secondPlaceScore + " Time: " + leaderboard.secondPlaceTime;
        thirdplace.text = leaderboard.thirdPlaceUsername + ": " + leaderboard.thirdPlaceScore + " Time: " + leaderboard.thirdPlaceTime;
    }
}
