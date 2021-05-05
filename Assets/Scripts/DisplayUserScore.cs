using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUserScore : MonoBehaviour
{

    [SerializeField]
    private PlayerStats playerStats;

    [SerializeField]
    private Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        displayText.text = playerStats.username + ": " + playerStats.Score + " Time: " + playerStats.totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
