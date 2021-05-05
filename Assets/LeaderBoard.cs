using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/LeaderBoard", order = 1)]
public class LeaderBoard : ScriptableObject
{
    void Start()
    {
        DontDestroyOnLoad(this);
    }
    
    public string firstPlaceUsername;

    public int firstPlaceScore;

    public float firstPlaceTime;

    public string secondPlaceUsername;

    public int secondPlaceScore;

    public float secondPlaceTime;

    public string thirdPlaceUsername;

    public int thirdPlaceScore;

    public float thirdPlaceTime;
}
