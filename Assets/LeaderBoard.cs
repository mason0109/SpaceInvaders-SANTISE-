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
    
    public string firstPlaceUsername = "";

    public int firstPlaceScore = 0;

    public float firstPlaceTime = 0;

    public string secondPlaceUsername = "";

    public int secondPlaceScore = 0;

    public float secondPlaceTime = 0;

    public string thirdPlaceUsername = "";

    public int thirdPlaceScore = 0;

    public float thirdPlaceTime = 0;
}
