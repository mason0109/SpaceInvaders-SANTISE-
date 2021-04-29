using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    [SerializeField]
    private GameObject lives1;

    [SerializeField]
    private GameObject lives2;

    [SerializeField]
    private GameObject lives3; 

    [SerializeField]
    private GameObject player;

    private bool playerDead = false;

    public PlayerStats playerStats;

    [SerializeField]
    private Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        lives1.transform.position = new Vector3(-7.73f, 6.41f, 0f);
        lives2.transform.position = new Vector3(-6.44f, 6.41f, 0f);
        lives3.transform.position = new Vector3(-5.15f, 6.41f, 0f);
        EventSystem.current.onFinalHitPlayerDies += playerDies;
        EventSystem.current.onEnemyKilledIncreaseScore += increaseScore;
        EventSystem.current.onGameOver += GameOver;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDead == false){
            //check the player's health
            checkPlayerHealth();
        }
    
    }

    void playerDies()
    {
        playerDead = true;
        GameOver();
    }

    void checkPlayerHealth()
    {
        switch(player.GetComponent<PlayerMovement>().playerLives)
        {
            case 2:
                lives3.transform.position = new Vector3(-5.15f, 6.41f, -50f);
                //player.transform.position = new Vector3(-8.3f, -5.45f, -0.01f);
                break;
            case 1:
                lives3.transform.position = new Vector3(-5.15f, 6.41f, -50f);
                lives2.transform.position = new Vector3(-6.44f, 6.41f, -50f);
                //player.transform.position = new Vector3(-8.3f, -5.45f, -0.01f);
                break;
            case 0:
                lives1.transform.position = new Vector3(-7.73f, 6.41f, -50f);
                lives2.transform.position = new Vector3(-6.44f, 6.41f, -50f);
                lives3.transform.position = new Vector3(-5.15f, 6.41f, -50f);
                GameOver();
                break;
        }
    }

    void increaseScore()
    {
        playerStats.Score = playerStats.Score + 50;
        scoreDisplay.text = "Score:  " + playerStats.Score;
    }

    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
