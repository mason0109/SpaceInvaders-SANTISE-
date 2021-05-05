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

    private PlayerMovement playerScript;

    private bool playerDead = false;

    public PlayerStats playerStats;

    private int numberOfEnemies;

    [SerializeField]
    private Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        lives1.transform.position = new Vector3(-7.73f, 6.41f, 0f);
        lives2.transform.position = new Vector3(-6.44f, 6.41f, 0f);
        lives3.transform.position = new Vector3(-5.15f, 6.41f, 0f);
        TimerController.instance.StartTimer();
        EventSystem.current.onFinalHitPlayerDies += playerDies;
        EventSystem.current.onEnemyKilledIncreaseScore += increaseScore;
        EventSystem.current.onGameOver += GameOver;
        EventSystem.current.onEmeniesKilledLevelComplete += LevelComplete;
        EventSystem.current.onEnemyKilled += enemyKilled;
        playerScript = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        numberOfEnemies = GameObject.FindObjectsOfType(typeof(RonaMovement)).Length;
        if (playerDead == false){
            //check the player's health
            checkPlayerHealth();
            checkNumberOfEnemies();
        }
    }

    void playerDies()
    {
        playerDead = true;
        GameOver();
    }

    void checkPlayerHealth()
    {
        switch(playerStats.playerLives)
        {
            case 2:
                lives3.transform.position = new Vector3(-5.15f, 6.41f, -50f);
                break;
            case 1:
                lives3.transform.position = new Vector3(-5.15f, 6.41f, -50f);
                lives2.transform.position = new Vector3(-6.44f, 6.41f, -50f);
                FindObjectOfType<AudioManager>().pauseCurrentSoundtrack();
                FindObjectOfType<AudioManager>().PlaySound("LastLifeSound");
                break;
            case 0:
                lives1.transform.position = new Vector3(-7.73f, 6.41f, -50f);
                lives2.transform.position = new Vector3(-6.44f, 6.41f, -50f);
                lives3.transform.position = new Vector3(-5.15f, 6.41f, -50f);
                GameOver();
                break;
        }
    }

    void checkNumberOfEnemies()
    {
        if (numberOfEnemies == 0)
        {
            EventSystem.current.enemiesKilledLevelComplete();
        }
    }

    void increaseScore()
    {
        playerStats.Score = playerStats.Score + 50;
        scoreDisplay.text = "Score:  " + playerStats.Score;
    }

    void enemyKilled()
    {
        numberOfEnemies--;
    }

    void GameOver()
    {
        if (SceneManager.GetActiveScene().buildIndex == 10){
            TimerController.instance.StopTimer();
            FindObjectOfType<AudioManager>().pauseCurrentSoundtrack();
            SceneManager.LoadScene(11);
            EventSystem.current.sceneChangeToHome();
        } else 
        {
            TimerController.instance.StopTimer();
            playerStats.totalTime = TimerController.instance.GetPlayerTime();
            FindObjectOfType<AudioManager>().pauseCurrentSoundtrack();
            SceneManager.LoadScene(7);
            playerScript.SavePlayer();
            EventSystem.current.sceneChangeToHome();
        }
    }

    void LevelComplete()
    {   
        if (SceneManager.GetActiveScene().buildIndex == 10){
            TimerController.instance.StopTimer();
            FindObjectOfType<AudioManager>().pauseCurrentSoundtrack();
            SceneManager.LoadScene(12);
            EventSystem.current.sceneChangeToHome();
        } else 
        {
            TimerController.instance.StopTimer();
            playerStats.totalTime = TimerController.instance.GetPlayerTime();
            FindObjectOfType<AudioManager>().pauseCurrentSoundtrack();
            SceneManager.LoadScene(8);
            playerStats.level = playerStats.level + 1;
            playerScript.SavePlayer();
            EventSystem.current.sceneChangeToHome();
        }
    }
}
