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
        firstplace.text = Leaderboard.firstPlaceUsername + ": " + Leaderboard.firstPlaceScore;
        secondplace.text = Leaderboard.secondPlaceUsername + ": " + Leaderboard.secondPlaceScore;
        thirdplace.text = Leaderboard.thirdPlaceUsername + ": " + Leaderboard.thirdPlaceScore;
    }
}
