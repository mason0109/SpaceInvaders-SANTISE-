using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    [SerializeField]
    private Text scoreDisplay;

    // Start is called before the first frame update
    public void StartUp(int score)
    {
        scoreDisplay.text = "Score: " + score;
    }
}
