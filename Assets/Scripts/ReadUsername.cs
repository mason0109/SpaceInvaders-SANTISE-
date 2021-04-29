using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadUsername : MonoBehaviour
{

    [SerializeField]
    private PlayerStats playerStats;

    private string userName;

    // Start is called before the first frame update
    void Start()
    {
        playerStats.Restart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadUserInput(string input)
    {
        userName = input;
        playerStats.username = userName;
    }
}
