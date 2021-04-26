using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScene : MonoBehaviour
{
    
    public Text pointsDisplay;

    public void StartUp(int score)
    {
        gameObject.SetActive(true);
        pointsDisplay.text = "Score: " + score.ToString();
    }
}
