using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadDropdown : MonoBehaviour
{
    [SerializeField]
    private PlayerStats playerStats;

    public void readDifficultyMenu(int menuoption)
    {
        if (menuoption == 0)
        {
            playerStats.Difficulty = "Easy";
        } 
        if (menuoption == 1)
        {
            playerStats.Difficulty = "Medium";
        }
        if (menuoption == 2)
        {
            playerStats.Difficulty = "Hard";
        }
    }
}
