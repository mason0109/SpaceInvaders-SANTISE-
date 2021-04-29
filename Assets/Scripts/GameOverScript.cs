using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    [SerializeField]
    private Text scoreDisplay;

    public PlayerStats playerStats;

    // Start is called before the first frame update
    public void Awake()
    {
        scoreDisplay.text = " " + playerStats.username + ": " + playerStats.Score;
    }
}
